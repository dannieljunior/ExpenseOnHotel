using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseOnHotel.Domain;
using ExpenseOnHotel.Infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ExpenseOnHotel.Infrastructure.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : ModelBase
    {
        protected readonly ExpenseOnHotelContext Context;

        public Repository(ExpenseOnHotelContext dbContext)
        {
            Context = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            try{
                await Context.Set<TEntity>().AddAsync(obj);
                return obj;
            }  
            catch(Exception ex){
                throw new Exception($"Erro ao tentar adicionar o registro. Mensagem da exceção original: {ex.Message}"); 
            }         
        }

        public async Task<TEntity> UpdateAsync(TEntity obj)
        {
            try{
                await Task.FromResult(Context.Update(obj));
                return obj;
            }
            catch(Exception ex){
                throw new Exception($"Erro ao tentar atualizar o registro. Mensagem da exceção original: {ex.Message}"); 
            }        
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try{
                var objToDelete = await GetByIdAsync(id);
                Context.Set<TEntity>().Remove(objToDelete);
                return true;
            }
            catch(Exception ex){
                throw new Exception($"Erro ao tentar excluir o registro. Mensagem da exceção original: {ex.Message}"); 
            }  
        }

        //Marcado comom virtual para uma possível sobreescrita do método, se necessário
        public virtual IQueryable<TEntity> GetAll(Func<TEntity, bool> query = null)
        {
            try{
                if(query == null)
                    return Context.Set<TEntity>().AsQueryable();
                
                return Context.Set<TEntity>().Where(query).AsQueryable();
            }
            catch(Exception ex){
                throw new Exception($"Erro ao efetuar consulta. Mensagem da exceção original: {ex.Message}"); 
            }  
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            try{
                return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
            }
            catch(Exception ex){
                throw new Exception($"Erro ao buscar registro pelo Id. Mensagem da exceção original: {ex.Message}"); 
            }
        }
    }
}