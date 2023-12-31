﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título é um campo obrigatório")]
    [MaxLength(300, ErrorMessage = "O campo título não pode exceder 300 caracteres")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero é um campo obrigatório")]
    [MaxLength (50, ErrorMessage = "O campo gênero não pode exceder 50 caracteres")]

    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração é um campo obrigatório")]
    [Range (70, 600, ErrorMessage = "A duração do filme deve ter de 70 a 600 minutos")]

    public int Duracao { get; set; }
    
}
