﻿namespace CRUD_Products.Models.Login.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Profile { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
