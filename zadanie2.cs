using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Podaj długość tablicy: ");
        int dlugosc = int.Parse(Console.ReadLine());

        // Zbiór dopuszczalnych wartości
        double[] dopuszczalneWartosci = { 2, 3, 3.5, 4, 4.5, 5 };
        Random random = new Random();
        
        // Generowanie tablicy
        double[] tablica = new double[dlugosc];
        for (int i = 0; i < dlugosc; i++)
        {
            tablica[i] = dopuszczalneWartosci[random.Next(dopuszczalneWartosci.Length)];
        }

        // Średnia, min, max
        double srednia = tablica.Average();
        double min = tablica.Min();
        double max = tablica.Max();

        // Wypisywanie wyników
        Console.WriteLine($"Średnia: {srednia}");
        Console.WriteLine($"Min: {min}, Max: {max}");

        // Wartości wyższe i niższe niż średnia
        var wyzsze = tablica.Where(x => x > srednia);
        var nizsze = tablica.Where(x => x < srednia);

        Console.WriteLine("Wartości wyższe niż średnia: " + string.Join(", ", wyzsze));
        Console.WriteLine("Wartości niższe niż średnia: " + string.Join(", ", nizsze));

        // Częstotliwość występowania
        var czestotliwosc = tablica.GroupBy(x => x)
            .Select(g => new { Wartosc = g.Key, Czestosc = g.Count() });

        Console.WriteLine("Częstotliwość:");
        foreach (var item in czestotliwosc)
        {
            Console.WriteLine($"{item.Wartosc}: {item.Czestosc} razy");
        }

        // Odchylenie standardowe
        double odchylenie = Math.Sqrt(tablica.Average(x => Math.Pow(x - srednia, 2)));
        Console.WriteLine($"Odchylenie standardowe: {odchylenie}");
    }
}
