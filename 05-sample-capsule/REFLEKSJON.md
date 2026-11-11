# Refleksjon — Sample Capsule

## Plan før koding

StringCapsule: \_content = content;
Read(): return \_content;
Replace(): \_content = content;

-

## Testlogg

| Inndata eller handling               | Forventet resultat | Faktisk resultat |
| ------------------------------------ | ------------------ | ---------------- |
| first.Read()                         | dust               | dust             |
| second.Read()                        | ice                | ice              |
| first.replace("rock") / first.Read() | rock               | rock             |
| second.Read()                        | ice                | ice              |

## Forklaring

Hvorfor skal \_content være et instansfelt og ikke static?

Mitt svar:
Fordi \_content kan være flere forskjellige ting til en hver tid.
Hvis den var static, så vill den være den siste string den ble tildelt.
Resultate i konsollen i dette tilfellet ville vert ice, ice, rock, rock.

## Hva endret jeg, og hvorfor?

StringCapsule: \_content = content; for å tildele \_content verdier.
Read(): return \_content; for å kunne lese verdiene.
Replace(): \_content = content; for å erstatte verdien med en annen verdi.

## Hva trenger jeg mer øving på?

## Sidenote

\ blir lagt til automatisk før liggestrekene når jeg saver filen.
