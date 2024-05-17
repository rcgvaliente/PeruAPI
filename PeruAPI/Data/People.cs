using System;
using System.Collections.Generic;

namespace PeruAPI.Data;

public partial class People
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? Dni { get; set; }
}
