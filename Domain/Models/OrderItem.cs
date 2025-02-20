﻿namespace Domain.Models;

public class OrderItem
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string Quantity { get; set; }
    public decimal PriceOfTheProductAtTheTimeOfOrder { get; set; }
    public decimal SubTotal { get; set; }
}
