using System;
using System.Collections.Generic;

namespace WebApplication5.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
