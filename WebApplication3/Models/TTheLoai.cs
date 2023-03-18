using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class TTheLoai
{
    public string MaTheLoai { get; set; } = null!;

    public string? TenTheLoai { get; set; }

    public virtual ICollection<TSach> TSaches { get; } = new List<TSach>();
}
