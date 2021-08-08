using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class OfferRepository : IOfferRepository
    {
        private readonly SalesContext _context;

        public OfferRepository(
            SalesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Offer offer)
        {
            _context.Offers.Remove(offer);
        }

        public void Insert(Offer offer)
        {
            _context.Offers.Add(offer);
        }

        public IQueryable<Offer> Query()
        {
            return _context.Offers.AsQueryable();
        }

        public void Update(Offer offer)
        {
            _context.Offers.Update(offer);
        }
    }
}
