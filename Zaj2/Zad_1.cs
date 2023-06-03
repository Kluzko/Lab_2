using System;

class Zad_1
{
    public static void ObliczSredniaArytmetyczna()
    {
        Console.WriteLine("Podaj trzy liczby:");

        Console.Write("Liczba 1: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba 2: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Liczba 3: ");
        double liczba3 = Convert.ToDouble(Console.ReadLine());

        double srednia = (liczba1 + liczba2 + liczba3) / 3;

        Console.WriteLine("Średnia arytmetyczna wynosi: " + srednia);
    }
}