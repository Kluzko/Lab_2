using System;

class Zad_6
{
    public static void SprawdzTrojkatRownoboczny()
    {
        Console.WriteLine("Podaj długości trzech boków trójkąta:");

        Console.Write("Bok 1: ");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bok 2: ");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bok 3: ");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        if (bok1 == bok2 && bok2 == bok3)
        {
            Console.WriteLine("Podane boki mogą utworzyć trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie mogą utworzyć trójkąta równobocznego.");
        }
    }
}