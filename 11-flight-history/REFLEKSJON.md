# Refleksjon — Flight History

## Plan før koding

-

## Testlogg

| Inndata eller handling           | Forventet resultat               | Faktisk resultat                 |
| -------------------------------- | -------------------------------- | -------------------------------- |
| history.Add("Launch", "Orbit")   | history 2                        | history 2                        |
| numbers.Add(42, 44)              | numbers 2                        | numbers 2                        |
| history.GetSnapshot()            | history 2, snapshot 2            | history 2, snapshot 2            |
| snapshot.Clear()                 | history 2, snapshot 0            | history 2, snapshot 0            |
| GetSnapshot(), Add("Landing, 13) | history 3, snapshot 2, numbers 3 | history 3, snapshot 2, numbers 3 |
| history.Clear()                  | history 0, snapshot 2, numbers 3 | history 0, snapshot 2, numbers 3 |

## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar:
Objektet vil fremdeles være delt. f.eks. hvis du endrer et navn fra Ida til Lars vil begge listene vise endringen. men dersom du fjerner det fra ene listen blir den femdeles værende i den andre listen.

## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
