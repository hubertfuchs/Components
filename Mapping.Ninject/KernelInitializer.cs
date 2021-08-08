using Ninject;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker;
using Fuchsbau.Components.CrossCutting.EmailMessaging.Contract;
using Fuchsbau.Components.CrossCutting.EmailMessaging.MailKit;
using Fuchsbau.Components.CrossCutting.Logging;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;
using Fuchsbau.Components.Logic.GoodsReceivingManagement;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingWorkflows;
using Fuchsbau.Components.Logic.GoodsReceivingWorkflows.Contract;
using Fuchsbau.Components.Logic.ProjectManagement;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;
using Fuchsbau.Components.Logic.ProjectWorkflows;
using Fuchsbau.Components.Logic.ProjectWorkflows.Contract;

namespace Fuchsbau.Components.Mappings.Mapping.Ninject
{
    public class KernelInitializer
    {
        public void Initialize(IKernel kernel)
        {


            kernel.Bind<IProjectFileWorkflow>().To<ProjectFileWorkflow>();
            kernel.Bind<IComplaintWorkflow>().To<ComplaintWorkflow>();

            kernel.Bind<ISubprojectManager>().To<SubprojectManager>();
            kernel.Bind<IProjectFileManager>().To<ProjectFileManager>();
            kernel.Bind<IComplaintImageManager>().To<ComplaintImageManager>();

            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IRoleRepository>().To<RoleRepository>();
            kernel.Bind<IRightRepository>().To<RightRepository>();
            kernel.Bind<IProjectRepository>().To<ProjectRepository>();
            kernel.Bind<ISubprojectRepository>().To<SubprojectRepository>();
            //kernel.Bind<IProjectFileRepository>().To<ProjectFileRepository>();
            kernel.Bind<IOfferRepository>().To<OfferRepository>();
            kernel.Bind<ISalesOrderRepository>().To<SalesOrderRepository>();
            kernel.Bind<IInvoiceRepository>().To<InvoiceRepository>();
            kernel.Bind<IComplaintImageRepository>().To<ComplaintImageRepository>();
            
            kernel.Bind<SecurityContext>().To<SecurityContext>().InSingletonScope();
            kernel.Bind<ProjectContext>().To<ProjectContext>().InSingletonScope();
            kernel.Bind<SalesContext>().To<SalesContext>().InSingletonScope();
            kernel.Bind<GoodsReceivingContext>().To<GoodsReceivingContext>().InSingletonScope();

            kernel.Bind<ILogger>().To<DebugLogger>().InSingletonScope();
            kernel.Bind<IMessageBroker>().To<MessageBroker>().InSingletonScope();
            kernel.Bind<IEmailSender>().To<MailKitEmailSender>().InSingletonScope();
            kernel.Bind<IEmailReceiver>().To<MailKitEmailReceiver>().InSingletonScope();
            //kernel.Bind<IMailMessageConverter>().To<MailKitMailMessageConverter<MimeMessage>>().InSingletonScope();
        }
    }
}
