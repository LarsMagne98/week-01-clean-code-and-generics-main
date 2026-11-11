# Refleksjon — Twin Recorders

## Plan før koding

Clear(): \_items.Clear();
Dele opp metodene og inndentere.

-

## Testlogg

| Inndata eller handling  | Forventet resultat | Faktisk resultat  |
| ----------------------- | ------------------ | ----------------- |
| text.Add("Orbit")       | count: 1           | count: 1          |
| numbers.Add(7)          | count: 1           | count: 1          |
| Søk etter "Orbit" / 7   | Begge gir true     | begge gir true    |
| Søk etter "Landing" / 9 | Begge gir false    | begger gir false  |
| Clear på begge          | Begge har Count 0  | begge har count 0 |
| Clear på tom beholder   | Count forblir 0    | count forblir 0   |

## Forklaring

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

Mitt svar:
De måtte ha gjort forskjellige ting. Disse klassene gjør det samme;
Legger inn verdier, lagrer verdiene i en liste, sjekker om listen inneholder spesifik verdi, og fjerner alle verdiene fra listen.

## Hva endret jeg, og hvorfor?

Clear(): \_items.Clear(); i begge klassene.
Rydda opp koden i begge klassene for å gjøre de lettere å lese.
la til flere testtilfeller for å sjekke at den fungerer slik den skal.

## Hva trenger jeg mer øving på?
