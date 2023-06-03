using System;

class Zad_7
{
    public static void SprawdzPunktWKole()
    {
        Console.WriteLine("Podaj współrzędne punktu P(x, y):");

        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj promień koła r: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double odlegloscOdSrodka = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        if (odlegloscOdSrodka <= r)
        {
            Console.WriteLine("Punkt P({0}, {1}) leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
        }
    }
}