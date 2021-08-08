using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contexts;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class ComplaintImageRepository : IComplaintImageRepository
    {
        private readonly GoodsReceivingContext _fsContext;

        public ComplaintImageRepository(
            GoodsReceivingContext fsContext)
        {
            _fsContext = fsContext ?? throw new ArgumentNullException(nameof(fsContext));
        }

        public void Delete(ComplaintImage complaintImage)
        {
            _fsContext.ComplaintImages.Remove(complaintImage);
        }

        public void Insert(ComplaintImage complaintImage)
        {
            _fsContext.ComplaintImages.Add(complaintImage);
        }

        public IQueryable<ComplaintImage> Query()
        {
            return _fsContext.ComplaintImages.AsQueryable();
        }

        public void Update(ComplaintImage complaintImage)
        {
            int index = _fsContext.ComplaintImages.IndexOf(complaintImage);
            _fsContext.ComplaintImages[index] = complaintImage;
        }
    }
}
