using GregorsGodsaksKontrakter;

namespace GregorsGodsaker.Services;

public interface ISnackservice
{
    Task<string?> GetSnacks();
}

public class SnackService(ISnacks snacksApi) : ISnackservice
{
    public async Task<string?> GetSnacks() 
        => await snacksApi.GetSnack();
}