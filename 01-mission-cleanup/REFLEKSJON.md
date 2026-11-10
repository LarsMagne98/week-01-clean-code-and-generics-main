# Refleksjon — Mission Cleanup

## Plan før koding

    Endre 'x' til "name".
    Rydde opp if/else blokken.
    Lage en konstant til minimum mannskapskravet.

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat  |
| ---------------------- | ------------------ | ----------------- |
| Ada, Bo, Cy            | Crew: 3 / Ready    | Crew: 3 / Ready   |
| Ada, Bo                | Crew: 2 / Waiting  | Crew: 2 / Waiting |
|                        | Crew: 0 / Waiting  | Crew: 0 / Waiting |

## Forklaring

Hvilken endring gjorde koden lettere å forstå uten å endre oppførselen?

Mitt svar:

Endre variabelnavn til noe selvforklarende. Legge inn tomme linjer mellom
linjer med kode. Dele opp if/else blokken over flere linjer.

## Hva endret jeg, og hvorfor?

Endret 'x' til "name", for å vise at listen inneholder navn på personer.
Lagde en konstant for minste krav av besetningen og ga den et beskrivende navn for å slippe en kommentar på hva "if" sjekker.

## Hva trenger jeg mer øving på?

Ingenting her.
