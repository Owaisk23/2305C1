using System;
using System.Collections.Generic;

namespace Dbfirst.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int Price { get; set; }

    public int? CatId { get; set; }

    public virtual Category? Cat { get; set; }
}
