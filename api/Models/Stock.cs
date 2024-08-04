namespace api.Models;

public class Stock
{
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty; // default value is ""
    // [Column(TypeName = "decimal(18,2)")]
    public decimal Purchase { get; set; }
    // [Column(TypeName = "decimal(18,2)")]
    public decimal LastDiv { get; set; }
    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
    // public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
}