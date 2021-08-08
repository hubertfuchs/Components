using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.Logic.ProjectManagement;

namespace Fuchsbau.Components.Data.FileStorage.Contexts
{
    [UnitOfWork]
    public class GoodsReceivingContext : IUnitOfWork
    {
        public List<ComplaintImage> ComplaintImages { get; set; }

        public GoodsReceivingContext()
        {
            
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
