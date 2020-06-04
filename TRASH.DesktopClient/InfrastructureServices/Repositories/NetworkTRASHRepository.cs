using TRASH.ApplicationServices.Ports.Cache;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TRASH.InfrastructureServices.Repositories
{
    public class NetworkTRASHRepository : NetworkRepositoryBase, IReadOnlyTRASHRepository
    {
        private readonly IDomainObjectsCache<trash> _trashCache;

        public NetworkTRASHRepository(string host, ushort port, bool useTls, IDomainObjectsCache<trash> trashCache)
            : base(host, port, useTls)
            => _trashCache = trashCache;

        public async Task<trash> GetTRASH(long id)
            => CacheAndReturn(await ExecuteHttpRequest<trash>($"trashs/{id}"));

        public async Task<IEnumerable<trash>> GetAllTRASHs()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<trash>>($"trashs"), allObjects: true);

        public async Task<IEnumerable<trash>> QueryTRASHs(ICriteria<trash> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<trash>>($"trashs"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<trash> CacheAndReturn(IEnumerable<trash> trashs, bool allObjects = false)
        {
            if (allObjects)
            {
                _trashCache.ClearCache();
            }
            _trashCache.UpdateObjects(trashs, DateTime.Now.AddDays(1), allObjects);
            return trashs;
        }

        private trash CacheAndReturn(trash trash)
        {
            _trashCache.UpdateObject(trash, DateTime.Now.AddDays(1));
            return trash;
        }
    }
}
