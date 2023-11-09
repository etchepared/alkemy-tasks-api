using david_etchepare.DataAccess;
using david_etchepare.Entities;
using Microsoft.EntityFrameworkCore;

namespace david_etchepare.Repository
{
    public class TareaRepository : Repository<Tarea>
    {
        public TareaRepository(ContextDB contextDB) : base(contextDB)
        {
        }

        public virtual async Task<List<Tarea>> GetAllTareas()
        {
            var tareas = await _contextDB.Tareas.ToListAsync();
            return tareas;
        }
    }
}
//Lo vamos a utilizar para los filtros