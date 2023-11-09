using david_etchepare.Repository;

namespace david_etchepare.Services
{
    public interface IUnitOfWork
    {
        public TareaRepository TareaRepository { get; set; }
    }
}
