using System;
using System.Collections.Generic;

namespace Shoes_Project_1_2.Models;

public partial class ProductStock
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int SizeId { get; set; }

    public int QuantityAvailable { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Size Size { get; set; } = null!;
}
