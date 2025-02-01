using Refit;

namespace GregorsGodsaksKontrakter;

public interface IWines
{
    [Get("/api/Wine")]
    Task<List<Wine>?> GetWines();
}