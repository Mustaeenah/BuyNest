
namespace Domain.Models;

public class Review :BaseEntities
{
    public int ReviewId { get; set; }
    public int ProductId {  get; set; }
    public int UserId {  get; set; }
    public string Rating { get; set; }
    public string Comment { get; set; }
}
