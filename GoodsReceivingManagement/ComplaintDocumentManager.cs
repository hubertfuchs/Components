using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;

namespace Fuchsbau.Components.Logic.GoodsReceivingManagement
{
    public class ComplaintDocumentManager : IComplaintDocumentManager
    {
        public ComplaintDocumentManager()
        {
        }

        public void Add(ComplaintDocument complaintDocument)
        {
            throw new NotImplementedException();
        }

        public ComplaintDocument Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ComplaintDocument> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ComplaintDocument complaintDocument)
        {
            throw new NotImplementedException();
        }

        public void Update(ComplaintDocument complaintDocument)
        {
            throw new NotImplementedException();
        }
    }
}