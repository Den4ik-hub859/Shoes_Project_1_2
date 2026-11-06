using System;
using System.Collections.Generic;

namespace Shoes_Project_1_2.Models;

public partial class Size
{
    public int Id { get; set; }

    public string SizeValue { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductStock> ProductStocks { get; set; } = new List<ProductStock>();
}
