# ProjectWDP

Projekt - gra BlackJack 

Projekt jest projektem gry karcianej typu blackjack.
Na początku talia jest tasowana po czym każdy z graczy otrzymuje po dwie karty.Następnie kartę może dobrać diler, potem gracz i tak na zmianę. Gdy jedna osoba skończy dobierać karty, druga nadal może je dobierać. Zgodnie z zasadami diler jeśli ma 17 punktów lub więcej, kart nie dobiera.Jeśli ma mniej niż 17, zawsze dobiera kartę. Jeśli któryś z graczy przekroczy sumę 21 punktów, przegrywa od razu i gra się kończy.Karty dilera są ukryte, gracz może zobaczyć je dopiero po zakończeniu danej rozgrywki.
(symbole K-kier, R-karo, T-trefl, P-pik)

Projekt ma bardzo prostą strukturę. W jej skład wchodzą trzy klasy:

1. Program- odpowiada za caly przebieg gry. Zawarte w niej też są funkcje:
 - compareHands - sprawdzająca wynik,porównująca wartości rąk graczy,sprawdzająca czy gra nie zakończyła się z powodu przekroczenia przez któregoś z graczy 21 punktów
 - showHand  - wyświetlająca karty które dany gracz ma w ręcę w danej rozgrywce(karty dilera wyświetlane są dopiero po zakończeniu danej rozgrywki)
 
2. Hand - odpowiada za przechowywanie informacji o ręce(kartach) danego gracza, posiada też funkcje:
-  handValue która sumuje "wartość" ręki danego gracza w danej rozgrywce BlackJacka(gdy gracz ma więcej niz 10 pkt As liczony jest jako 1, gdy mniej - jako 11)
-  listę cardsInHand przechowującą karty znajdujace się w ręce danego gracza

3. Deck -odpowiada za przechowywanie talii używanej do obecnej rozgrywki i tasowanie jej po zakończonej rozgrywce,jej funkcje to
- shuffle - "tasuje" talie - robi nową listę wszystkich kombinacji figura+ wartosc
- drawCard - dobiera losową kartę z talii i usuwą ją z obecnej talii- dzięki temu mamy pewność że dana karta nie zostanie wyciągnięta dwa razy
