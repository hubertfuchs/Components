using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.Plugin.Contract;

namespace Fuchsbau.Components.CrossCutting.Plugin
{
    public class TestExecutionMain : IExecutionMain
    {
        private readonly ILogger _logger;
        private readonly IManager<string> _manager;
        private readonly IRepository<string> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TestExecutionMain(
            ILogger logger,
            IManager<string> manager,
            IRepository<string> repository,
            IUnitOfWork unitOfWork )
        {
            _logger = logger ?? throw new ArgumentNullException( nameof( logger ) );
            _manager = manager ?? throw new ArgumentNullException( nameof( manager ) );
            _repository = repository ?? throw new ArgumentNullException( nameof( repository ) );
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException( nameof( unitOfWork ) );
        }

        public void Run()
        {
            try
            {
                _logger.LogAsync( "Herzlich willkommen!" );

                string newEntity = "id=0815";

                _manager.Add( newEntity );
                _manager.Add( "id=007" );

                foreach( var item in _manager.GetAll() )
                {
                    _logger.Log( $"{item} --- läuft bei mir" );
                }

                _manager.Remove( newEntity );

                if( _manager.GetAll().Count() == 0 )
                {
                    _logger.Log( "keine entity", LogLevel.Information );
                }
                else
                {
                    _logger.Log( "entity immer noch da", LogLevel.Warning );
                }

                _logger.Log( "falsches log level angegeben...", LogLevel.None );

                throw new Exception( "weil-ich-es-kann-Exception" );
            }
            catch( Exception ex )
            {
                _logger.Log( $"{ex}", LogLevel.Error );
            }

            _logger.LogAsync( "Game Over" );
        }
    }
}
