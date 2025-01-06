using System;
using System.Collections.Generic;

namespace TempEmbeddin2302C2.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public int Amount { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User User { get; set; } = null!;
}
