using GregorsGodsaksKontrakter;
using Microsoft.AspNetCore.Mvc;

namespace GregorsGodsakApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WineController : ControllerBase
{
    [HttpGet]
    public IActionResult GetWines()
    {
        var wines = new List<Wine>
        {
            new()
            {
                Id = new Guid("5c088e3b-a8b4-43a7-8b7c-4760e39a5752"),
                Name = "Marqués de Cáceres Crianza 2018",
                TypeOfWine = WineType.Red,
                AlcoholPercent = 14,
                Price = 370,
                Year = 2018
            },
            new()
            {
                Id = new Guid("2a0b3afc-d2d7-4f06-aa46-f244f34a7b63"),
                Name = "Gran Coronas Reserva 2016",
                TypeOfWine = WineType.Red,
                AlcoholPercent = 14,
                Price = 370,
                Year = 2016
            },
            new()
            {
                Id = new Guid("205aeac6-afad-4c6f-ae5c-6b7e0db51541"),
                Name = "Angiolino Maule Pico 2020",
                TypeOfWine = WineType.White,
                AlcoholPercent = 12.5,
                Price = 408,
                Year = 2020
            },
            new()
            {
                Id = new Guid("f410a7ed-3826-4d16-aded-eb7945222c67"),
                Name = "Van Volxem Volz Riesling GG",
                TypeOfWine = WineType.White,
                AlcoholPercent = 12.5,
                Price = 529,
                Year = 2022
            },
            new()
            {
                Id = new Guid("fbb949df-a286-46da-a728-cb9af262132a"),
                Name = "Messmer Pinot Noir Trocken 2022",
                TypeOfWine = WineType.Rosé,
                AlcoholPercent = 11.5,
                Price = 200,
                Year = 2022
            }
        };

        return Ok(wines);
    }
}