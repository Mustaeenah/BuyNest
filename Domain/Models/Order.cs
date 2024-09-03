namespace Domain.Models;

public class Order : BaseEntities
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public decimal TotalAmount { get; set; }
    public enum OrderStatus { pending,shipped,delivered }
    public enum PaymentStatus { paid,pending,failed}
    public OrderItem OrderItem { get; set; }
}
