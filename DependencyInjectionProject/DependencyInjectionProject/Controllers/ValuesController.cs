using DependencyInjectionProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ValuesController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public IActionResult Get()
        {
            _teacher.GetInfo();

            return Ok();
        }
    }
}
