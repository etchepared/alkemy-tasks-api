using david_etchepare.DataAccess;
using david_etchepare.DTOs;
using david_etchepare.Entities;
using Microsoft.EntityFrameworkCore;
using david_etchepare.Services;

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

        public async Task<bool> InsertTarea(TareaRegisterDTO tareaRegisterDTO)
        {
            try 
            {
                var tareas = new Tarea();
                tareas = tareaRegisterDTO;

                return await base.Insert(tareas);
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
//Lo vamos a utilizar para los filtros