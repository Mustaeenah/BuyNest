﻿namespace Domain.Models;

public class BaseEntities
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
     public DateTime Modified { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
