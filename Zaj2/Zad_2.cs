using System;

class Zad_2
{
    public static void ObliczObwodKola()
    {
        Console.WriteLine("Podaj pole koła:");

        double pole = Convert.ToDouble(Console.ReadLine());

        double promien = Math.Sqrt(pole / Math.PI);

        double obwod = 2 * Math.PI * promien;

        Console.WriteLine("Obwód koła wynosi: " + obwod);
    }
}