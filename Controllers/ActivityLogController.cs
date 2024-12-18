using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System_API.Repository.interfaces;
using Task_Management_System_API.Services.interfaces;

namespace Task_Management_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class ActivityLogController : ControllerBase
    {
        private readonly IActivityService activityService;

        public ActivityLogController(IActivityService activityService)
        {
            this.activityService = activityService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = activityService.GetAllActivity();
            return Ok(result);
        }

        [HttpGet("{Id:int}")]
        public IActionResult GetById(int Id)
        {
            var result = activityService.GetActivityById(Id);
            if(result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
