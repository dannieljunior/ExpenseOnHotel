using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseOnHotel.Domain;

namespace ExpenseOnHotel.Infrastructure.Contracts
{
    public interface IRepository<TEntity> where TEntity: IEntity
    {
         Task<TEntity> AddAsync(TEntity obj);
         Task<TEntity> UpdateAsync(TEntity obj);
         Task<bool> DeleteAsync(Guid id);
         IQueryable<TEntity> GetAll(Func<TEntity, bool> query = null);  
         Task<TEntity> GetByIdAsync(Guid id);       
    }
}