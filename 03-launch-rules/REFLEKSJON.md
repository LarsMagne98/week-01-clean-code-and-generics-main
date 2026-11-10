# Refleksjon — Launch Rules

## Plan før koding

Endre metoden til å bruke earlyreturn.
kalle medtoden flere ganger med forskjellige argumenter.

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| 3, 50, true            | true               | true             |
| 2, 50, true            | false              | false            |
| 3, 49, true            | false              | false            |
| 3, 50, false           | false              | false            |
| 4, 80, true            | true               | true             |

## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Mitt svar:
Koden sjekker fremdeles de samme kravene.

## Hva endret jeg, og hvorfor?

Endret metoden til å bruke earlyreturn for å slippe alle nested if/else blokkene.

## Hva trenger jeg mer øving på?
