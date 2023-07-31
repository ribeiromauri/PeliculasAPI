﻿using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Genero : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
