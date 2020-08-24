using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using task_management.app_application.interfaces;

namespace task_management.app_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TasksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<int> Inserir(app_core.entities.Task entity)
        {
            var resultado = await _unitOfWork.Tasks.Add(entity);

            return resultado;
        }
    }
}
