﻿using System.ComponentModel.DataAnnotations;

namespace FitVision.Modul2.Models
{
    public class Drzava
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string? Skracenica { get; set; }
    }

}
