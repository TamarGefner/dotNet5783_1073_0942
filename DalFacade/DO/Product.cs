﻿
namespace DO;

public struct Product
{
    /// <summary>
    /// The ID of the product
    /// </summary>
    public int ID { get; set; }
    /// <summary>
    /// The name of the product
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The price of the product
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// The Category of the product
    /// </summary>
    public Category? Category { get; set; }
    /// <summary>
    /// The amount in Stock of the product
    /// </summary>
    public int InStock { get; set; }
    /// <summary>
    /// pictures according to the products
    /// </summary>
    public string picture { get; set; }

    public override string ToString() => this.ToStringProperty();


}
