﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string Topic { get; set; }
        [Required]
        public DateTime AwnserTime { get; set; }
        public bool IsHaveAwnser { get; set; }
        public string Awnser { get; set; }

        //Navigation
        public ApplicationUser User { get; set; }
    }
}
