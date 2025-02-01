using GregorsGodsaksKontrakter;

namespace GregorsGodsaker.Components.Services;

public interface ISnackService
{
    Task<List<Snack>?> GetSnacks();
    Task<List<Wine>?> GetWines();
}

public class SnackService(ISnacks snacksApi, IWines wineApi) : ISnackService
{
    public async Task<List<Snack>?> GetSnacks()
    {
        return await snacksApi.GetSnack();
    }

    public async Task<List<Wine>?> GetWines()
    {
        return await wineApi.GetWines();
    }
}