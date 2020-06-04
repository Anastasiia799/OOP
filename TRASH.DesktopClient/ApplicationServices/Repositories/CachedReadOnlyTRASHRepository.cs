using TRASH.ApplicationServices.Ports.Cache;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using TRASH.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Repositories
{

    public class CachedReadOnlyTRASHRepository : ReadOnlyTRASHRepositoryDecorator
    {
        private readonly IDomainObjectsCache<trash> _trashsCache;

        public CachedReadOnlyTRASHRepository(IReadOnlyTRASHRepository trashRepository, 
                                             IDomainObjectsCache<trash> trashsCache)
            : base(trashRepository)
            => _trashsCache = trashsCache;

        public async override Task<trash> GetTRASH(long id)
            => _trashsCache.GetObject(id) ?? await base.GetTRASH(id);

        public async override Task<IEnumerable<trash>> GetAllTRASHs()
            => _trashsCache.GetObjects() ?? await base.GetAllTRASHs();

        public async override Task<IEnumerable<trash>> QueryTRASHs(ICriteria<trash> criteria)
            => _trashsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryTRASHs(criteria);

    }
}
