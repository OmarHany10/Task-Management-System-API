﻿using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.UserDTOs
{
    public class LoginDTO
    {
        [Required]
        [Display(Name = "Emair or Username")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
