namespace GregorsGodsaksKontrakter;

public class Wine
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public WineType TypeOfWine { get; set; }
    public double AlcoholPercent { get; set; }
    public int Price { get; set; }
    public int Year { get; set; }
}

public enum WineType
{
    Red,
    White,
    Rosé
}