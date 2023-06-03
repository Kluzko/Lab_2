using System;

class Zad_3
{
    public static void ObliczBMI()
    {
        Console.WriteLine("Podaj wagę [kg]:");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wzrost [cm]:");
        double wzrostCm = Convert.ToDouble(Console.ReadLine());

        // Konwersja wzrostu z cm na m
        double wzrostM = wzrostCm / 100;


        double bmi = waga / (wzrostM * wzrostM);

        Console.WriteLine("Współczynnik BMI wynosi: " + bmi);
    }
}