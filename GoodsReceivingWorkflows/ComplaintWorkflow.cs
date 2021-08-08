using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingWorkflows.Contract;

namespace Fuchsbau.Components.Logic.GoodsReceivingWorkflows
{
    public class ComplaintWorkflow : IComplaintWorkflow
    {
        private readonly ILogger _logger;
        private readonly IMessageBroker _messageBroker;
        private readonly IConfiguration _configuration;
        private readonly IComplaintImageManager _complaintImageManager;
        private readonly IDocumentGenerator _documentGenerator;
        private readonly IComplaintDocumentManager _complaintDocumentManager;

        private enum ProcessState
        {
            Inactive, Active
        }

        private ProcessState _processState = ProcessState.Inactive;
        private string _complaintEmailBody = string.Empty;

        public ComplaintWorkflow(
            ILogger logger,
            IMessageBroker messageBroker,
            IConfiguration configuration,
            IComplaintImageManager complaintImageManager,
            IDocumentGenerator documentGenerator,
            IComplaintDocumentManager complaintDocumentManager )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _messageBroker = messageBroker ?? throw new ArgumentNullException(nameof(messageBroker));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _complaintImageManager = complaintImageManager ?? throw new ArgumentNullException(nameof(complaintImageManager));
            _documentGenerator = documentGenerator ?? throw new ArgumentNullException(nameof(documentGenerator));
            _complaintDocumentManager = complaintDocumentManager ?? throw new ArgumentNullException(nameof(complaintDocumentManager));
            
            _messageBroker.Subscribe<RenameFilesResponseMessage>(RenameFilesCallback);
        }

        public void AddArticlePhoto(uint purchaseOrderNumber, ComplaintImage complaintImage)
        {
            complaintImage.PurchaseOrderNumber = purchaseOrderNumber;

            _complaintImageManager.Add(complaintImage);
        }

        public void AddDeliveryNotePhoto(uint purchaseOrderNumber, ComplaintImage complaintImage)
        {
            complaintImage.PurchaseOrderNumber = purchaseOrderNumber;

            _complaintImageManager.Add(complaintImage);
        }

        public void MergeUserInputAndTemplate(string description)
        {
            // ResourceFile.GetComplaintTemplate()
            string complaintTemplate =
                @"Sehr geehrte Damen und Herren,\nhiermit reklamieren wir den bei Ihnen bestellte Artikel.\n\n{0}\n\nMit freundlichen Grüßen\nFuchs AG";

            _complaintEmailBody = string.Format(complaintTemplate, description);
        }

        public void CreatePdfFileForEachPhoto(uint purchaseOrderNumber)
        {
            foreach (var complaintImage in _complaintImageManager.GetAll())
            {
                ComplaintDocument complaintDocument = (ComplaintDocument) _documentGenerator.Generate(complaintImage);

                complaintDocument.PurchaseOrderNumber = purchaseOrderNumber;

                _complaintDocumentManager.Add(complaintDocument);
            }
        }

        public void RenameDocumentFiles(uint purchaseOrderNumber)
        {
            string[] files = _complaintDocumentManager.GetAll().Select(x => Path.Combine(x.Path, x.File)).ToArray();
            string newFileName = $"{purchaseOrderNumber}";

            RenameFilesRequestMessage message = new RenameFilesRequestMessage(files, newFileName);
            _messageBroker.Publish(message);

            _processState = ProcessState.Active;
        }

        public async Task SendEmail(uint purchaseOrderNumber)
        {
            if (string.IsNullOrWhiteSpace(_complaintEmailBody))
            {
                throw new InvalidOperationException();
            }

            string emailAddressTo = _configuration.Get<string>("Purchasing", "ComplaintEmailAddress");
            string emailSubject = "Reklamation"; // ResourceFile.GetComplaintSubject()
            string emailBody = _complaintEmailBody;

            await Task.Run(() =>
            {
                while (_processState == ProcessState.Active)
                {
                    _logger.Log("Process is active, i.e. this system component is busy.");
                }
            });

            string[] files = _complaintDocumentManager.GetAll()
                .Where(x => x.PurchaseOrderNumber == purchaseOrderNumber)
                .Select(x => Path.Combine(x.Path, x.File)).ToArray();

            string[] emailAttachments = files;

            var message = new SendEmailCommandMessage(emailAddressTo, emailSubject, emailBody, emailAttachments);
            _messageBroker.Publish(message);
        }

        private void RenameFilesCallback( RenameFilesResponseMessage message )
        {
            //message
            //_complaintDocumentManager.GetAll().Where(x => x.)

            _processState = ProcessState.Inactive;
        }
    }
}
