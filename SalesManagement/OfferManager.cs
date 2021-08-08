using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Logic.SalesManagement.Contract;

namespace Fuchsbau.Components.Logic.SalesManagement
{
    public class OfferManager : IOfferManager
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IOfferNoteRepository _offerNoteRepository;
        private readonly IOfferItemRepository _offerItemRepository;
        private readonly IOfferItemCommentRepository _offerItemCommentRepository;

        public OfferManager(
            IOfferRepository offerRepository,
            IOfferNoteRepository offerNoteRepository,
            IOfferItemRepository offerItemRepository,
            IOfferItemCommentRepository offerItemCommentRepository )
        {
            _offerRepository = offerRepository ?? throw new ArgumentNullException( nameof( offerRepository ) );
            _offerNoteRepository = offerNoteRepository ?? throw new ArgumentNullException( nameof( offerNoteRepository ) );
            _offerItemRepository = offerItemRepository ?? throw new ArgumentNullException( nameof( offerItemRepository ) );
            _offerItemCommentRepository = offerItemCommentRepository ?? throw new ArgumentNullException( nameof( offerItemCommentRepository ) );
        }

        public void Add( Offer offer )
        {
            _offerRepository.Insert( offer );
        }

        public Offer Get( Guid id )
        {
            return _offerRepository.Query().Single( x => x.Id == id );
        }

        public IQueryable<Offer> GetAll()
        {
            return _offerRepository.Query();
        }

        public void Remove( Offer offer )
        {
            _offerRepository.Delete( offer );
        }

        public void Update( Offer offer )
        {
            _offerRepository.Update( offer );
        }
    }
}
