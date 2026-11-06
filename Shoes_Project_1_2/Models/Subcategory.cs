using System;
using System.Collections.Generic;

namespace Shoes_Project_1_2.Models;

public partial class Subcategory
{
    public int Id { get; set; }

    public string SubcategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
