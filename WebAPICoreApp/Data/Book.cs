using System;
using System.Collections.Generic;

namespace WebAPICoreApp.Data;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }
}
