using System;
using System.Collections.Generic;

namespace WebApplication5.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int? StockAmount { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<ProductStore> ProductStores { get; set; } = new List<ProductStore>();
}
