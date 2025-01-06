using System;
using System.Collections.Generic;

namespace TempEmbeddin2302C2.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public int UserId { get; set; }

    public string CardHolderName { get; set; } = null!;

    public long CardNumber { get; set; }

    public int Cvc { get; set; }

    public DateTime PaymentDate { get; set; }
}
