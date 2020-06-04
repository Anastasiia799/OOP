using TRASH.ApplicationServices.Ports.Gateways.Database;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Repositories
{
    public class DbTRASHRepository : IReadOnlyTRASHRepository,
                                     IRTRASHRepository
    {
        private readonly ITRASHDatabaseGateway _databaseGateway;

        public DbTRASHRepository(ITRASHDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<trash> GetTRASH(long id)
            => await _databaseGateway.GetTRASH(id);

        public async Task<IEnumerable<trash>> GetAllTRASHs()
            => await _databaseGateway.GetAllTRASHs();

        public async Task<IEnumerable<trash>> QueryTRASHs(ICriteria<trash> criteria)
            => await _databaseGateway.QueryTRASHs(criteria.Filter);

        public async Task AddTRASH(trash trash)
            => await _databaseGateway.AddTRASH(trash);

        public async Task RemoveTRASH(trash trash)
            => await _databaseGateway.RemoveTRASH(trash);

        public async Task UpdateTRASH(trash trash)
            => await _databaseGateway.UpdateTRASH(trash);
    }
}
