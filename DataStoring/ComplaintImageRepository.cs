using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class ComplaintImageRepository : IComplaintImageRepository
    {
        private readonly GoodsReceivingContext _context;

        public ComplaintImageRepository(
            GoodsReceivingContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(ComplaintImage image)
        {      
            _context.ComplaintImages.Remove(image);
        }

        public void Insert(ComplaintImage image)
        {
            _context.ComplaintImages.Add(image);
        }

        public IQueryable<ComplaintImage> Query()
        {
            return _context.ComplaintImages.AsQueryable();
        }

        public void Update(ComplaintImage image)
        {
            _context.ComplaintImages.Update(image);
        }
    }
}