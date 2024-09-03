namespace Domain.Models;

public class Payment : BaseEntities
{
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public int UserId {  get; set; }
    public decimal AmountPaid { get; set; }
   

}
public enum PaymentStatus { completed, pendind }