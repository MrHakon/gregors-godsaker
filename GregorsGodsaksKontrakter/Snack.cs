namespace GregorsGodsaksKontrakter;

public class Snack
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int Rating { get; set; }
    public int Weight { get; set; }
    public int CaloriesPer100Grams { get; set; }
    public int PerceivedDurationOfTasteInSeconds { get; set; }
    public int Price { get; set; }
    public int NumInStock { get; set; }
    public SnackCategory Category { get; set; }
    public FlavorCategory Flavor { get; set; }
}