using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARJE20250319.AppWebMVC.Models;

public partial class User
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio.")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "La contraseña es obligatorio.")]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    public string PasswordHash { get; set; } = null!;

    [Required(ErrorMessage = "El Rol es obligatorio.")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("PasswordHash", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}
