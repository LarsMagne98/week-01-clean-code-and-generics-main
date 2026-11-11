# Refleksjon — Paired Beacons

## Plan før koding

Opprette Pair<T>, First og Second. metode til å gi de verdi. En Read() metode.
Opprette PairDisplay, metode ShowPair<T>

-

## Testlogg

| Inndata eller handling                 | Forventet resultat                                      | Faktisk resultat |
| -------------------------------------- | ------------------------------------------------------- | ---------------- |
|                                        |                                                         |                  |
| "North", "South"                       | First er North, Second er South; ShowPair skriver begge | <--              |
| 12, 24                                 | First er 12, Second er 24; ShowPair skriver begge       | <--              |
| To Beacon-objekter med navn A og B     | First.Name er A, Second.Name er B                       | <--              |
| Nytt par etter første par              | Første par er uendret                                   | <--              |
| Forsøk å tilordne First fra Program.cs | Kompileringsfeil; fjern feilkallet før levering         | <--              |

## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

Mitt svar:
Pair<T> lagrer og gir tilbake verdier av typen T. Den trenger ikke lese egenskapene, Det gjør koden i Program.cs, der typen er kjent som Beacon.
Generics lar den samme Pair<T> klassen brukes som Pair<string>, <int>, <Beacon>. Uten generics måtte jeg laget seperate klasser for alle typene, selv om de lagrer to verdier og oppfører seg likt.

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
