using System;
using System.Collections.Generic;

namespace TempEmbeddin2302C2.Models;

public partial class Category
{
    public int CatId { get; set; }

    public string CatName { get; set; } = null!;

    public string CatDesc { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
