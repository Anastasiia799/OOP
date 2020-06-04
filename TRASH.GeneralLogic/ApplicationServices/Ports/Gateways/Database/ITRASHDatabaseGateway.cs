using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TRASH.ApplicationServices.Ports.Gateways.Database
{
    public interface ITRASHDatabaseGateway
    {
        Task AddTRASH(trash trash);

        Task RemoveTRASH(trash trash);

        Task UpdateTRASH(trash trash);

        Task<trash> GetTRASH(long id);

        Task<IEnumerable<trash>> GetAllTRASHs();

        Task<IEnumerable<trash>> QueryTRASHs(Expression<Func<trash, bool>> filter);

    }
}
