using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FEMM20250319.Models;

public partial class User
{
    public int UserId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;
    [Required(ErrorMessage = "El password es obligatorio.")]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}
