﻿using System.ComponentModel.DataAnnotations;

namespace eAuction_touchdown.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your strong password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please Confirmpassword")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}