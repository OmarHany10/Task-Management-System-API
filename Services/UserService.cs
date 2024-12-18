using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Task_Management_System_API.Data;
using Task_Management_System_API.Models;
using Task_Management_System_API.Models.DTO.UserDTOs;
using Task_Management_System_API.Services.interfaces;

namespace Task_Management_System_API.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext context) 
        {
            this.context = context;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return context.Users.ToList();
        }

        public async Task<ApplicationUser> GetByID(string id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Id ==id);
        }

        public async Task<ApplicationUser> Update(string id, UpdateUserDTO user)
        {
            var oldUser = await GetByID(id);
            if (oldUser != null)
            {
                oldUser.FirstName = user.FirstName;
                oldUser.LastName = user.LastName;
                oldUser.Email = user.Email;
                oldUser.UserName = user.Usermame;
            }
            context.Users.Update(oldUser);
            return oldUser;
        }
        public async Task<int> Delete(string id)
        {
            var user = await GetByID(id);
            if (user != null)
            {
                context.Users.Remove(user);
                return 1;
            }
            return 0;
        }
    }
}
