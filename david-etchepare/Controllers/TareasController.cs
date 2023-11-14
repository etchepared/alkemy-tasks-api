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
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _unitOfWork.TareaRepository.GetAllTareas());
        }
    }
}
