using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Task_Management_System_API.Models.DTO.UserDTOs;
using Task_Management_System_API.Services;
using Task_Management_System_API.Services.interfaces;
using Task_Management_System_API.UOK;

namespace Task_Management_System_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IActivityService activityService;
        private readonly ITaskService taskService;

        public UserController(IUnitOfWork unitOfWork, IActivityService activityService, ITaskService taskService)
        {
            this.unitOfWork = unitOfWork;
            this.activityService = activityService;
            this.taskService = taskService;
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = unitOfWork.Users.GetAll();
            return Ok(users);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(string id)
        {
            var user = await unitOfWork.Users.GetByID(id);
            if (user == null)
            {
                return NotFound(user);
            }
            return Ok(user);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> Update(string id, UpdateUserDTO updateUserDTO)
        {
            if (await unitOfWork.Users.GetByID(id) == null)
                return NotFound("No User Have this ID");

            var user = await unitOfWork.Users.Update(id, updateUserDTO);
            unitOfWork.save();
            return Ok(user);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            int result = await unitOfWork.Users.Delete(id);
            unitOfWork.save();
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{Id}/activity")]
        public IActionResult GetAllUserActivity(string Id)
        {
            var result = activityService.GetAllUserActivity(Id);
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{userId}/Tasks")]
        public IActionResult GetAllTasks(string userId)
        {
            var result = taskService.GetTasksAssignToUser(userId);
            return Ok(result);
        }

        [HttpGet("MyActivity")]
        public IActionResult GetMyActivity()
        {
            var userId = User.FindFirst("uid")?.Value;
            var result = activityService.GetAllUserActivity(userId);
            return Ok(result);
        }

        [HttpGet("MyTasks")]
        public IActionResult GetMyTasks()
        {
            var userId = User.FindFirst("uid")?.Value;
            var result = taskService.GetTasksAssignToUser(userId);
            return Ok(result);
        }
    }
}
