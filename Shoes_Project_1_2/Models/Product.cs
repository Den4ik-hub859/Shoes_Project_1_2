using System;
using System.Collections.Generic;

namespace Shoes_Project_1_2.Models;

public partial class Product
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int SubcategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public int ManufacturerId { get; set; }

    public string? ImageFile { get; set; }

    public string? Description { get; set; }

    public string? Composition { get; set; }

    public decimal Price { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductStock> ProductStocks { get; set; } = new List<ProductStock>();

    public virtual Subcategory Subcategory { get; set; } = null!;
}
