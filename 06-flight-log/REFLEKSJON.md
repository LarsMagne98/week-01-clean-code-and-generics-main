# Refleksjon — Flight Log

## Plan før koding

Count: return \_entries.Count;
Add: \_entries.Add(entry);
Clear: \_entries.Clear();

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| Ny logg                | 0                  | 0                |
| log.Add("Launch")      | 1                  | 1                |
| log.Add("Orbit")       | 2                  | 2                |
| log.Clear()            | 0                  | 0                |
| log.Clear()            | 0                  | 0                |
| log.Add("")            | 1                  | 1                |
| Ny logg2               | 0                  | 0                |

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

Mitt svar:
Risikoen er at et eget tellerfelt er lett for å glemme å oppdatere riktig hvis du f.eks. fjerner alt fra listen.

## Hva endret jeg, og hvorfor?

Count: return \_entries.Count; for å få riktig antall fra listen, til og med når alt fjernes fra listen.
Add: \_entries.Add(entry); for å legge til nye ting i listen.
Clear: \_entries.Clear(); for å fjerne alt fra listen.

## Hva trenger jeg mer øving på?
