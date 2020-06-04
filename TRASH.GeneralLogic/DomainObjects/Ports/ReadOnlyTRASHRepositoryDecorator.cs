using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.DomainObjects.Repositories
{
    public abstract class ReadOnlyTRASHRepositoryDecorator : IReadOnlyTRASHRepository
    {
        private readonly IReadOnlyTRASHRepository _trashRepository;

        public ReadOnlyTRASHRepositoryDecorator(IReadOnlyTRASHRepository trashRepository)
        {
            _trashRepository = trashRepository;
        }

        public virtual async Task<IEnumerable<trash>> GetAllTRASHs()
        {
            return await _trashRepository?.GetAllTRASHs();
        }

        public virtual async Task<trash> GetTRASH(long id)
        {
            return await _trashRepository?.GetTRASH(id);
        }

        public virtual async Task<IEnumerable<trash>> QueryTRASHs(ICriteria<trash> criteria)
        {
            return await _trashRepository?.QueryTRASHs(criteria);
        }
    }
}
