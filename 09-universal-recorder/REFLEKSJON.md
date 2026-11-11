# Refleksjon — Universal Recorder

## Plan før koding

Legge til Type i klassen.
Gjøre listen om til <T>.
Add(T item).
Contains(T item).
legge til alle testtilfellene.

-

## Testlogg

| Inndata eller handling         | Forventet resultat | Faktisk resultat |
| ------------------------------ | ------------------ | ---------------- |
| Ny textRecorder                | count: 0           | count: 0         |
| Ny numberRecorder              | count: 0           | count: 0         |
| textRecorder.Add("Orbit")      | count: 1           | count: 1         |
| textRecorder.Contains("Orbit") | true               | true             |
| textRecorder.Contains("orbit") | false              | false            |
| numberRecorder.Add(7) x2       | count: 2           | count: 2         |
| numberRecorder.Contains(7)     | true               | true             |
| numberRecorder.Count           | 0                  | 0                |
| textRecorder.Count             | 1                  | 1                |

## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar:
Count skal alltid være en int. Man teller med tall.
Contains svarer alltid true / false, det endres ikke selv om verdien er tekst eller tall.

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
