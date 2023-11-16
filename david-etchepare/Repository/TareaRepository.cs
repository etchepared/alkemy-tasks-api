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
            var tareas = await _contextDB.Tareas.Where(t => t.IsCompleted == false).ToListAsync();
            return tareas;
        }

        public async Task<Tarea?> GetTareasById(int id)
        {
            try 
            { 
                var tareas = await _contextDB.Tareas.Where(t => t.Id == id).FirstOrDefaultAsync();
                return tareas;
            }
            catch (Exception ex) 
            {
                return null;
            }
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

        public async Task<bool> UpdateTarea(TareaRegisterDTO tareaRegisterDTO, int id)
        {
            try
            {
                var tareas = new Tarea();
                tareas = tareaRegisterDTO;
                tareas.Id = id;
                tareas.IsCompleted = tareaRegisterDTO.IsCompleted;

                return await base.Update(tareas);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteTarea(int id)
        {
            try 
            {
                var tareas = await GetTareasById(id);
                tareas.IsCompleted = true;
                
                return await base.Update(tareas);
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
//Lo vamos a utilizar para los filtros