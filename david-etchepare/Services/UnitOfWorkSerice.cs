using david_etchepare.DataAccess;
using david_etchepare.Repository;

namespace david_etchepare.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly ContextDB _contextDB;
        public TareaRepository TareaRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB) 
        {
            _contextDB = contextDB;
            TareaRepository = new TareaRepository(contextDB);
        }

        public Task<int> Complete()
        {
            return _contextDB.SaveChangesAsync();
        }
    }
}
//el unit of work es un intermediario entre el controlador y el repository