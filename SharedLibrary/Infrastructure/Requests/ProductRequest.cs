﻿namespace SharedLibrary.Infrastructure.Requests;

public class ProductRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal DiscountPercentage { get; set; }
    public string ImageFileName { get; set; }
}