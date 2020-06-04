using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Repositories
{
    public class InMemoryTRASHRepository : IReadOnlyTRASHRepository,
                                           IRTRASHRepository 
    {
        private readonly List<trash> _trashs = new List<trash>();

        public InMemoryTRASHRepository(IEnumerable<trash> trashs = null)
        {
            if (trashs != null)
            {
                _trashs.AddRange(trashs);
            }
        }

        public Task AddTRASH(trash trash)
        {
            _trashs.Add(trash);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<trash>> GetAllTRASHs()
        {
            return Task.FromResult(_trashs.AsEnumerable());
        }

        public Task<trash> GetTRASH(long id)
        {
            return Task.FromResult(_trashs.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<trash>> QueryTRASHs(ICriteria<trash> criteria)
        {
            return Task.FromResult(_trashs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveTRASH(trash trash)
        {
            _trashs.Remove(trash);
            return Task.CompletedTask;
        }

        public Task UpdateTRASH(trash trash)
        {
            var foundTRASH = GetTRASH(trash.Id).Result;
            if (foundTRASH == null)
            {
                AddTRASH(trash);
            }
            else
            {
                if (foundTRASH != trash)
                {
                    _trashs.Remove(foundTRASH);
                    _trashs.Add(trash);
                }
            }
            return Task.CompletedTask;
        }
    }
}
