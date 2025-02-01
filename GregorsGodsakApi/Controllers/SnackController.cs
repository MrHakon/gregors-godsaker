using GregorsGodsaksKontrakter;
using Microsoft.AspNetCore.Mvc;

namespace GregorsGodsakApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SnackController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSnacks()
    {
        var snacks = new List<Snack>
        {
            new()
            {
                Id = new Guid("40d4071d-d531-4e27-836d-5ef20dc502bc"),
                Name = "Lollipop Rainbow",
                ExpirationDate = DateTime.Parse("2025-12-15"),
                Rating = 5,
                Weight = 50,
                CaloriesPer100Grams = 200,
                PerceivedDurationOfTasteInSeconds = 120,
                Price = 10,
                NumInStock = 150,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("40406f7e-11dc-4c37-8b47-e74884ad0960"),
                Name = "Gummy Bears",
                ExpirationDate = DateTime.Parse("2025-08-30"),
                Rating = 4,
                Weight = 80,
                CaloriesPer100Grams = 250,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 20,
                NumInStock = 200,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sour
            },
            new()
            {
                Id = new Guid("8c8f2261-e2fa-4d10-a5fe-699bdcb084ec"),
                Name = "Sour Worms",
                ExpirationDate = DateTime.Parse("2025-11-01"),
                Rating = 3,
                Weight = 70,
                CaloriesPer100Grams = 210,
                PerceivedDurationOfTasteInSeconds = 100,
                Price = 20,
                NumInStock = 180,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sour
            },
            new()
            {
                Id = new Guid("4a1c7f5c-89d1-4f55-8711-fd33993adb31"),
                Name = "Chocolate Truffles",
                ExpirationDate = DateTime.Parse("2025-05-15"),
                Rating = 5,
                Weight = 120,
                CaloriesPer100Grams = 300,
                PerceivedDurationOfTasteInSeconds = 150,
                Price = 40,
                NumInStock = 120,
                Category = SnackCategory.Chocolate,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("031b7a6d-7a88-4dc9-bad5-e993143a0010"),
                Name = "Hard Candy Lemon",
                ExpirationDate = DateTime.Parse("2025-09-10"),
                Rating = 4,
                Weight = 40,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 60,
                Price = 10,
                NumInStock = 250,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sour
            },
            new()
            {
                Id = new Guid("747b1028-8114-4c92-8fa6-ea9aeab84ab5"),
                Name = "Mint Candy",
                ExpirationDate = DateTime.Parse("2025-07-01"),
                Rating = 5,
                Weight = 50,
                CaloriesPer100Grams = 150,
                PerceivedDurationOfTasteInSeconds = 120,
                Price = 10,
                NumInStock = 300,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Fresh
            },
            new()
            {
                Id = new Guid("d2dee591-334c-4080-b7ed-3bdf639f3a41"),
                Name = "Caramel Chews",
                ExpirationDate = DateTime.Parse("2025-06-25"),
                Rating = 4,
                Weight = 60,
                CaloriesPer100Grams = 220,
                PerceivedDurationOfTasteInSeconds = 130,
                Price = 20,
                NumInStock = 100,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("6b77e000-2d3b-4daa-8c81-50f67ee10206"),
                Name = "Sour Candies Pack",
                ExpirationDate = DateTime.Parse("2025-10-10"),
                Rating = 3,
                Weight = 90,
                CaloriesPer100Grams = 240,
                PerceivedDurationOfTasteInSeconds = 110,
                Price = 30,
                NumInStock = 160,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sour
            },
            new()
            {
                Id = new Guid("d3c7114b-d1e1-4556-ae90-a67b5064f7ed"),
                Name = "Chili Chocolate",
                ExpirationDate = DateTime.Parse("2025-04-05"),
                Rating = 4,
                Weight = 55,
                CaloriesPer100Grams = 300,
                PerceivedDurationOfTasteInSeconds = 140,
                Price = 30,
                NumInStock = 90,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Bitter
            },
            new()
            {
                Id = new Guid("62a02702-cf14-482c-b9a5-f9d820eb07ca"),
                Name = "Fruit Jellies",
                ExpirationDate = DateTime.Parse("2025-12-20"),
                Rating = 5,
                Weight = 85,
                CaloriesPer100Grams = 230,
                PerceivedDurationOfTasteInSeconds = 100,
                Price = 20,
                NumInStock = 200,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("95af80c1-0789-4f3c-834c-bfb45a111c77"),
                Name = "Pønsjrull",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = -3,
                Weight = 100,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 29,
                NumInStock = 3,
                Category = SnackCategory.Cake,
                Flavor = FlavorCategory.Bitter
            },
            new()
            {
                Id = new Guid("7747c8ce-3a72-4adf-a37d-b3797aa4698d"),
                Name = "Peach Rings",
                ExpirationDate = DateTime.Parse("2025-06-12"),
                Rating = 4,
                Weight = 50,
                CaloriesPer100Grams = 210,
                PerceivedDurationOfTasteInSeconds = 80,
                Price = 10,
                NumInStock = 170,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sour
            },
            new()
            {
                Id = new Guid("aaf2b80b-c67f-42fa-a069-a43dced3ae2e"),
                Name = "Gummy Bears Mix",
                ExpirationDate = DateTime.Parse("2025-08-25"),
                Rating = 5,
                Weight = 100,
                CaloriesPer100Grams = 270,
                PerceivedDurationOfTasteInSeconds = 110,
                Price = 20,
                NumInStock = 220,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("136e6fe3-561e-415c-987d-c900d5d3b8ac"),
                Name = "Licorice Twists",
                ExpirationDate = DateTime.Parse("2025-07-30"),
                Rating = 3,
                Weight = 40,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 70,
                Price = 10,
                NumInStock = 140,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Salty
            },
            new()
            {
                Id = new Guid("1f486f19-745e-4246-964d-7fba43eeaddf"),
                Name = "Cinnamon Fireballs",
                ExpirationDate = DateTime.Parse("2025-10-15"),
                Rating = 4,
                Weight = 45,
                CaloriesPer100Grams = 230,
                PerceivedDurationOfTasteInSeconds = 100,
                Price = 20,
                NumInStock = 190,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("b1827296-2017-49f4-9526-2980ec9fb42d"),
                Name = "Cotton Candy",
                ExpirationDate = DateTime.Parse("2025-06-30"),
                Rating = 5,
                Weight = 60,
                CaloriesPer100Grams = 300,
                PerceivedDurationOfTasteInSeconds = 60,
                Price = 30,
                NumInStock = 130,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("e75d7e37-e792-4925-97a3-b487993f3f95"),
                Name = "Punsj-rull",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = -3,
                Weight = 100,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 29,
                NumInStock = 3,
                Category = SnackCategory.Cake,
                Flavor = FlavorCategory.Bitter
            },
            new()
            {
                Id = new Guid("6a8281ae-358c-454d-8cce-3b6d9c285dfa"),
                Name = "Taffy Bites",
                ExpirationDate = DateTime.Parse("2025-11-12"),
                Rating = 4,
                Weight = 80,
                CaloriesPer100Grams = 250,
                PerceivedDurationOfTasteInSeconds = 120,
                Price = 20,
                NumInStock = 140,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("56251bea-fc63-4869-81ba-8675c2148893"),
                Name = "Ginger Candies",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = 3,
                Weight = 50,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 20,
                NumInStock = 80,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Bitter
            },
            new()
            {
                Id = new Guid("0ca02882-20fb-4f87-9136-982a907e7edc"),
                Name = "Saltstenger",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = 3,
                Weight = 50,
                CaloriesPer100Grams = 100,
                PerceivedDurationOfTasteInSeconds = 7,
                Price = 20,
                NumInStock = 10,
                Category = SnackCategory.SaltSnack,
                Flavor = FlavorCategory.Salty
            },
            new()
            {
                Id = new Guid("74a0eb23-0617-4c15-bf13-4a5288ee3dc4"),
                Name = "Meat balls",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = 3,
                Weight = 50,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 20,
                NumInStock = 80,
                Category = SnackCategory.Food,
                Flavor = FlavorCategory.Umami
            },
            new()
            {
                Id = new Guid("545ea411-67d4-40e4-806f-144fcf44f668"),
                Name = "Punsjrull",
                ExpirationDate = DateTime.Parse("2025-05-05"),
                Rating = -3,
                Weight = 100,
                CaloriesPer100Grams = 180,
                PerceivedDurationOfTasteInSeconds = 90,
                Price = 29,
                NumInStock = 3,
                Category = SnackCategory.Cake,
                Flavor = FlavorCategory.Bitter
            },
            new()
            {
                Id = new Guid("60b408d3-02f7-46cd-9fb6-4154d8017be0"),
                Name = "Strawberry Lollipops",
                ExpirationDate = DateTime.Parse("2025-03-28"),
                Rating = 5,
                Weight = 30,
                CaloriesPer100Grams = 190,
                PerceivedDurationOfTasteInSeconds = 70,
                Price = 10,
                NumInStock = 230,
                Category = SnackCategory.Candy,
                Flavor = FlavorCategory.Sweet
            },
            new()
            {
                Id = new Guid("f28ee03c-88bf-4265-9a4c-a18094108c7d"),
                Name = "Chocolate Fudge",
                ExpirationDate = DateTime.Parse("2025-04-20"),
                Rating = 5,
                Weight = 120,
                CaloriesPer100Grams = 350,
                PerceivedDurationOfTasteInSeconds = 180,
                Price = 40,
                NumInStock = 60,
                Category = SnackCategory.Chocolate,
                Flavor = FlavorCategory.Sweet
            }
        };


        return Ok(snacks);
    }
}