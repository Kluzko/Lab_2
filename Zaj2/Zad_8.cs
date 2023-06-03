using System;

class Zad_8
{
    public static void Kalkulator()
    {
        Console.WriteLine("Podaj dwie liczby:");
        Console.Write("Liczba 1: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba 2: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.Write("Numer działania: ");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        double wynik = 0;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Dzielenie przez zero! Wynik: {0}/0", liczba1);
                    return;
                }
                break;
            default:
                Console.WriteLine("Niepoprawny numer działania!");
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}
