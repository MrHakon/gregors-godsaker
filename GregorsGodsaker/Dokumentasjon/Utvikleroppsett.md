# Gregors Godsaker

## Oppsett og oppstart

Løsningen Gregors Godsaker består av de tre prosjektene som er beskrevet under. Det er kun nødvendig å kjøre to av dem:
GregorsGodsaker og GregorsGodsakApi.

### GregorsGodsaker

I forbindelse med oppgaven som skal løses, så er det her det skjer. Hvis du får en "Internal error" når du starter opp
denne, så er det fordi API-et ikke kjører.

En klient basert på Blazor. Når man utvikler en klient vil man gjerne se endringene sine forløpende med "Hot reload",
som laster siden inn på nytt hver gang man utfører en endring og lagrer filen man har endret. Avhengig av IDE, kan det
være ulike veier til mål, men et triks som fungerer bra, er å navigere til klientens filsti i en terminal (eks
innebygget terminal i Jetbrains Rider) og kjøre kommandoen "dotnet watch".

```
cd <sti til mappe. Eks: "C:\gregors-godsaker\GregorsGodsaker"> 
dotnet watch
```

Siden skal åpne seg automatisk, men om det ikke er tilfellet, kan man gå til følgende url (definert i
launchSettings.json): http://localhost:5037

**Gotcha:** Hot reload er ikke perfekt, så hvis endringer i koden ikke reflekteres i klienten, kan man trykke "ctrl + r"
i terminalen for å tvinge en reload. Eksempler er endringer i CSS-filer, som nettleseren kanskje har cachet.

#### GregorsGodsakApi

I forbindelse med oppgaven trenger man ikke å tenke på denne, annet enn at den må kjøre for å kunne gi data til
klienten.

Men dersom dere velger å løse oppgaven på en måte som krever utvidelse av datagrunnlaget, kan det gjøres her. Dersom
returtypen endres, må også ISnacks elle IWines i GregorsGodsaksKontrakter endres.

### GregorsGodsaksKontrakter

I forbindelse med oppgaven trenger man ikke å tenke på denne.

Det er et prosjekt som inneholder modeller som API-et bruker, samt et Refit-interface for å utføre API-kall. Dette kan
deles til alle .NET-prosjekter som ønsker å implementere mot API-et vårt, og sørger for at modellene som utveksles
stemmer på en prikk, samt at riktig REST-configurasjon håndheves. Akkurat de samme modellene blir benyttet av klienten,
og Refit mapper automatisk for oss.