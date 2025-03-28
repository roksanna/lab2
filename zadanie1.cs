using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczby do posortowania (oddzielone spacją): ");
        string input = Console.ReadLine();
        string[] liczbyTekst = input.Split(' ');
        int[] liczby = Array.ConvertAll(liczbyTekst, int.Parse);

        SortowanieBabelkowe(liczby);

        Console.WriteLine("Posortowane liczby: " + string.Join(" ", liczby));
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamieniono;
        do
        {
            zamieniono = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    (tablica[i], tablica[i + 1]) = (tablica[i + 1], tablica[i]); 
                    zamieniono = true;
                }
            }
        } while (zamieniono);
    }
}
