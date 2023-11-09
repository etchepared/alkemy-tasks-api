using david_etchepare.DataAccess;
using david_etchepare.Repository;

namespace david_etchepare.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        public TareaRepository TareaRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB) 
        {
            TareaRepository = new TareaRepository(contextDB);
        }
    }
}
//el unit of work es un intermediario entre el controlador y el repository