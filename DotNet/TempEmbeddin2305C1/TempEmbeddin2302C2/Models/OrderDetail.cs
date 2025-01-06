using System;
using System.Collections.Generic;

namespace TempEmbeddin2302C2.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int UserId { get; set; }

    public int Price { get; set; }

    public int ItemId { get; set; }

    public int Qty { get; set; }

    public int Total { get; set; }

    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
