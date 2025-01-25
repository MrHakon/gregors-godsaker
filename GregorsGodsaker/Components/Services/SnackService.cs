using GregorsGodsaksKontrakter;

namespace GregorsGodsaker.Components.Services;

public interface ISnackService
{
    Task<List<string>?> GetSnacks();
}

public class SnackService(ISnacks snacksApi) : ISnackService
{
    public async Task<List<string>?> GetSnacks() 
        => await snacksApi.GetSnack();
}