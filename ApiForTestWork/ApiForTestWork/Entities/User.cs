using System;
using System.Collections.Generic;

namespace ApiForTestWork.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Image> ImageFroms { get; } = new List<Image>();

    public virtual ICollection<Image> ImageTos { get; } = new List<Image>();
}
