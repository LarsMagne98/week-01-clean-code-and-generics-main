# Refleksjon — Cargo Calculator

## Plan før koding

Fjerne all eksisterende kode. Lage en metode med (int capacity, int usedCapacity).
returnere capacity - usedCapacity.
kalle metoden inne i flere Console.WriteLine() med alle testtallene.

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| 12, 5                  | 7                  | 7                |
| 20, 8                  | 12                 | 12               |
| 5, 5                   | 0                  | 0                |
| 0, 0                   | 0                  | 0                |

## Forklaring

Hva er parameterne, argumentene og returverdien i ett av kallene dine?

Mitt svar:
Parameterne er capacity og usedCapacity i parantesen i medoten.
Argumenter er de (i dette tilfelle) tallene som blir gitt til metoden når den kalles.
returverdien er det medoten returnerer til kalleren etter å ha utført operasjonen (capacity - usedCapacity).

## Hva endret jeg, og hvorfor?

Skrev om hele koden til en metode som kan bli brukt uendelig mange ganger i stedet for å definere hvert enkelte variabel for å så kalkulere de.
Kaller så metoden med argumenter rett i Console.WriteLine().

## Hva trenger jeg mer øving på?

Forstå når static er nødvendig eller ikke.
