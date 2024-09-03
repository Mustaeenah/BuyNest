namespace Domain.Models;

public class CartItem
{
    public int CartItemId { get; set; }
    public int ShoppingCartId { get; set;}
    public int AmountOfProduct { get; set; }
    public decimal PriceOfTheProductAtTimeItWasAddedToCart {  get; set; }
    public decimal SubTotal {  get; set; }
}
