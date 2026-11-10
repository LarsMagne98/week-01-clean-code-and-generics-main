# Refleksjon — Signal Types

## Plan før koding

- label er type string.
  retries er int. "3" så hadde det vert en string. '3' så hadde det vert en char.
  messages er List med typen string.
  result er string.

## Testlogg

| Inndata eller handling        | Forventet resultat                        | Faktisk resultat                          |
| ----------------------------- | ----------------------------------------- | ----------------------------------------- |
| Opprinnelig program           | "Echo: READY"                             | "Each: READY"                             |
| Aktiver messages.Add(42)      | Kompileringsfeil: listen forventer string | Kompileringsfeil: listen forventer string |
| Aktiver retries = "Three"     | Kompileringsfeil: retries er en int       | Kompileringsfeil: retries er en int       |
| Legger til en string i listen | Count blir 2                              | Count blir 2                              |

## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar:
string er en type. label er en tekstverdi av typen string (array av chars).
var retries kan ikke bare gjøres om til string etter at den første definisjonen er int.

## Hva endret jeg, og hvorfor?

Endret retries til en string. Endret .Add(42) til .Add(retries).

## Hva trenger jeg mer øving på?
