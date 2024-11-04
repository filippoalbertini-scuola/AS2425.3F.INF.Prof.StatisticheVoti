using System.Diagnostics;

namespace AS2425._3F.INF.Prof.StatisticheVoti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;04/11/24;Statistiche voti");

            Random r = new Random();
            long voto;

            Console.WriteLine("Digita il numero di studenti della prova");
            int nStudenti = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nStudenti; i++)
            {
                voto = r.Next(1, 11);
                Console.WriteLine($"{i} {voto}");
            }

        }
    }
}
