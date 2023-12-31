﻿using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Location
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool? IsDelete { get; set; }

    public virtual ICollection<Manufactory> Manufactories { get; set; } = new List<Manufactory>();
}
