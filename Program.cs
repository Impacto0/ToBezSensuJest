// Wczytywanie liczby można zrobić krócej ale wtedy nie ma sprawdzania czy liczba jest poprawna
Console.WriteLine("Podaj liczbę: ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
	Console.WriteLine("Nieprawidłowa liczba");
	return;
}

int wynik = 0;
int mnoznik = 1;

/* Mnożnik jest poto aby przesunąć liczbę na odpowiednie miejsce
 * 
 * 	1234
 * 
 * 	1234 % 10 = 4
 * 	4 + (1 * 10) = 14
 * 	123 % 10 = 3
 * 	14 + (3 * 100) = 314
 * 	12 % 10 = 2
 * 	314 + (2 * 1000) = 2314
 * 	1 % 10 = 1
 * 	2314 + (1 * 10000) = 12314
 * 
 * 	wynik = 12314
 */

while (n > 0)
{
	int liczba = n % 10;
	n /= 10;
	liczba++;
	
	if (liczba == 10)
	{
		wynik += liczba * mnoznik;
		mnoznik *= 100;
	}
	else
	{
		wynik += liczba * mnoznik;
		mnoznik *= 10;
	}
}

Console.WriteLine(wynik);


