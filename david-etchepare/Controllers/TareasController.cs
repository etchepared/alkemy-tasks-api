using david_etchepare.DTOs;
using david_etchepare.Services;
using Microsoft.AspNetCore.Mvc;

namespace david_etchepare.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public TareasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAllTareas")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWork.TareaRepository.GetAllTareas());
        }

        [HttpPost]
        [Route("PostTarea")]
        public async Task<ActionResult> Register(TareaRegisterDTO tareaRegisterDTO)
        {
            var result = await _unitOfWork.TareaRepository.InsertTarea(tareaRegisterDTO);
            if (result)
            {
                await _unitOfWork.Complete();
                return Ok("Se guardó correctamente.");
            }
            return BadRequest("Error al crear.");
        }

        [HttpPut]
        [Route("UpdateTarea")]
        public async Task<ActionResult> Update(int id, TareaRegisterDTO tareaRegisterDTO)
        {
            var result = await _unitOfWork.TareaRepository.UpdateTarea(tareaRegisterDTO, id);
            if (result)
            {
                await _unitOfWork.Complete();
                return Ok("Se actualizó correctamente.");
            }
            return BadRequest("Error al actualizar.");
        }

        [HttpDelete]
        [Route("DeleteTarea")]
        public async Task<ActionResult> Delete(int id) 
        {
            var result = await _unitOfWork.TareaRepository.DeleteTarea(id);
            if(result)
            {
                await _unitOfWork.Complete();
                return Ok("Se eliminó correctamente.");
            }
            return BadRequest("Error al eliminar");
        }
    }
}
