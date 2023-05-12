﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fluentify.Models.Frontend
{
    public class CreateUserRequest
    {
        [Required(ErrorMessage = "Nickname is required.")]
        [StringLength(50)]
        public string? Nickname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$",
        ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter and one number.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Registration date is required.")]
        [DataType(DataType.Date)]
        public DateTime? RegDate { get; set; }

    }
}
