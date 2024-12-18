﻿using Task_Management_System_API.Models;

namespace Task_Management_System_API.Repository.interfaces
{
    public interface ICommentRepository: IBaseRepository<Comment>
    {
        IEnumerable<Comment> GetAllTaskComments(int taskId);
        IEnumerable<Comment> GetAllUserComments(string userId);
    }
}
