﻿using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Admin
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }



    }
}
