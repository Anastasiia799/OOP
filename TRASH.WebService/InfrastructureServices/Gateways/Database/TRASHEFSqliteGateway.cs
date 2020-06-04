using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using TRASH.ApplicationServices.Ports.Gateways.Database;

namespace TRASH.InfrastructureServices.Gateways.Database
{
    public class TRASHEFSqliteGateway : ITRASHDatabaseGateway
    {
        private readonly TRASHContext _trashContext;

        public TRASHEFSqliteGateway(TRASHContext TRASHContext)
            => _trashContext = TRASHContext;

        public async Task<trash> GetTRASH(long id)
           => await _trashContext.TRASHs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<trash>> GetAllTRASHs()
            => await _trashContext.TRASHs.ToListAsync();
          
        public async Task<IEnumerable<trash>> QueryTRASHs(Expression<Func<trash, bool>> filter)
            => await _trashContext.TRASHs.Where(filter).ToListAsync();

        public async Task AddTRASH(trash trash)
        {
            _trashContext.TRASHs.Add(trash);
            await _trashContext.SaveChangesAsync();
        }

        public async Task UpdateTRASH(trash trash)
        {
            _trashContext.Entry(trash).State = EntityState.Modified;
            await _trashContext.SaveChangesAsync();
        }

        public async Task RemoveTRASH(trash trash)
        {
            _trashContext.TRASHs.Remove(trash);
            await _trashContext.SaveChangesAsync();
        }

    }
}
