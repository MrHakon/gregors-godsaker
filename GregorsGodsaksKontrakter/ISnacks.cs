using Refit;

namespace GregorsGodsaksKontrakter;

public interface ISnacks
{
    [Get("/api/Snack")]
    Task<List<string>?> GetSnack();
}