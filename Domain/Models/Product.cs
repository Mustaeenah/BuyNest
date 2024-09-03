namespace Domain.Models;

public class Product : BaseEntities
{
    public int ProductId {  get; set; }
    public int OrderId { get; set; }
    public int OrderItemId {  get; set; }
    public string ProductCategory { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal Price {  get; set; }
    public int? StockQuantity { get; set;}
    public string ImageURLs {  get; set; }  
    public string Attributes { get; set; }
    public int CategoryId { get; set; }

}
