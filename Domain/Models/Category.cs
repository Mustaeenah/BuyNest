namespace Domain.Models;

public class Category :BaseEntities
{
    public int CategoryId { get; set; }  
    public string Name { get; set; }
    public string Description { get; set; }
}
