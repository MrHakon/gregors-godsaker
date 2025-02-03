using Microsoft.AspNetCore.Components;

namespace GregorsGodsaker.Components.Components;

partial class InputComponent : ComponentBase
{
    /* Disse blir satt i HTML-koden, ved hjelp av @bind-Value, straks brukeren flytter fokus fra input-feltet.
    Det er bare sånn det virker. Men du kan også bruke en kombinasjon av Value og onchange for å oppnå det samme, eller
    gjøre noe mer enn å oppdatere en variabel, som å validere noe eller endre en farge et sted */
    private string InputTekst1 { get; set; } = string.Empty;
    private string InputTekst2 { get; set; } = string.Empty;
}