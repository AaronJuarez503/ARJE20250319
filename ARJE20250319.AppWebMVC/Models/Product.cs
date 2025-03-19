using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARJE20250319.AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    [Required(ErrorMessage = "El Precio es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio debe estar entre 0.01 y 99999999.99")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "No se aceptan letras, solo números")]
    public decimal Price { get; set; }

    [Display(Name = "Categorias")]
    public int? CategoryId { get; set; }

    [Display(Name = "Marcas")]

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }
}
