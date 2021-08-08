using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;

namespace Fuchsbau.Components.Logic.GoodsReceivingManagement
{
    public class ComplaintImageManager : IComplaintImageManager
    {
        private readonly IComplaintImageRepository _complaintImageRepository;

        public ComplaintImageManager(
            IComplaintImageRepository complaintImageRepository)
        {
            _complaintImageRepository = complaintImageRepository ?? throw new ArgumentNullException(nameof(complaintImageRepository));
        }

        public void Add(ComplaintImage complaintImage)
        {
            _complaintImageRepository.Insert(complaintImage);
        }

        public ComplaintImage Get(Guid id)
        {
            return _complaintImageRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<ComplaintImage> GetAll()
        {
            return _complaintImageRepository.Query();
        }

        public void Remove(ComplaintImage complaintImage)
        {
            _complaintImageRepository.Delete(complaintImage);
        }

        public void Update(ComplaintImage complaintImage)
        {
            _complaintImageRepository.Update(complaintImage);
        }
    }
}
