using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class TNhaCungCap
{
    public string MaNcc { get; set; } = null!;

    public string? TenNcc { get; set; }

    public virtual ICollection<THoaDonNhap> THoaDonNhaps { get; } = new List<THoaDonNhap>();
}
