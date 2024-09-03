namespace Domain.Models;

public class Users : BaseEntities
{
    public  int UserId { get; set; }
    public string FirstName { get; set; } = default;
    public string LastName { get; set; } = default;
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string PhoneNumberConfirmed { get; set; }
    public string EmailConfirmed { get; set; }
    public string ImageURLs { get; set; }
    public Order Order { get; set; }
    
}
