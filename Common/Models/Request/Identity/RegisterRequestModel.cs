﻿namespace Common.Models.Request.Identity
{
    public class RegisterRequestModel
    {
        //[Required]
        public string UserName { get; set; }
        // [Required]
        public string Password { get; set; }
        // [Required]
        // [EmailAddress]
        public string Email { get; set; }
    }
}
