using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARJE20250319.AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    [Required(ErrorMessage = "El Precio es obligatorio.")]
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten números y puntos.")]

    public decimal Price { get; set; }

    public int? BrandId { get; set; }

    public int? WarehouseId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
