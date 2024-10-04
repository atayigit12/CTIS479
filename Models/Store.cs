using System;
using System.Collections.Generic;

namespace WebApplication5.Models;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsVirtual { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<ProductStore> ProductStores { get; set; } = new List<ProductStore>();
}
