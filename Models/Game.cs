namespace PatikaFirstDbContext.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;
    public decimal Rating { get; set; }
} 