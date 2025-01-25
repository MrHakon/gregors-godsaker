using Microsoft.AspNetCore.Components;

namespace GregorsGodsaker.Components.Components;

partial class InputComponent : ComponentBase
{
    // Disse blir satt i HTML-koden, ved hjelp av @bind-Value, straks brukeren flytter fokus fra input-feltet.
    private string InputTekst1 { get; set; } = string.Empty;
    private string InputTekst2 { get; set; } = string.Empty;
}