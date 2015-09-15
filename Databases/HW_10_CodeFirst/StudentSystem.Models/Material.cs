﻿namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        public Material()
        {
        }

        public int MaterialID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
