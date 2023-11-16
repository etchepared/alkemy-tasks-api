using Microsoft.EntityFrameworkCore;
using david_etchepare.DataAccess;
using david_etchepare.Repository.Interfaces;

namespace david_etchepare.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ContextDB _contextDB;

        public Repository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public virtual async Task<List<T>> GetAll()
        {
            var entity = await _contextDB.Set<T>().ToListAsync();
            return entity;
        }

        public async Task<bool> Insert(T entity)
        {
            try 
            { 
                _contextDB.Set<T>().Add(entity);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
