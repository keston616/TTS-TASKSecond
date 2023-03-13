using System;
using System.Collections.Generic;

namespace ApiForTestWork.Entities;

public partial class Image
{
    public int Id { get; set; }

    public int FromId { get; set; }

    public int ToId { get; set; }

    public byte[]? Buffer { get; set; }

    public virtual User From { get; set; } = null!;

    public virtual User To { get; set; } = null!;
}
