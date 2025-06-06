﻿using System;
using System.Collections.Generic;

namespace ARJE20250319.AppWebMVC.Models;

public partial class Warehouses
{
    public int WarehouseID { get; set; }

    public string WarehouseName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
