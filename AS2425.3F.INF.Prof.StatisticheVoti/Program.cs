using System.Diagnostics;

namespace AS2425._3F.INF.Prof.StatisticheVoti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;04/11/24;Statistiche voti");

            Random r = new Random();
            int voto;

            int nNegativi = 0;
            int nNegativiPari = 0;
            int nNegativiDispari = 0;

            double mediaVoti = 0;
            double mediaVotiPari = 0;
            double mediaVotiDispari = 0;

            int nPari = 0;
            int nDispari = 0;

            Console.WriteLine("Digita il numero di studenti della prova");
            int nStudenti = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nStudenti; i++)
            {
                voto = r.Next(1, 11);

                Console.Write($"Studente {i} : voto {voto}");

                if (voto < 6)
                    nNegativi++;

                mediaVoti += voto;

                if (i % 2 == 0)
                {
                    // pari
                    nPari++;
                    if (voto < 6)
                        nNegativiPari++;
                    mediaVotiPari += voto;
                    Console.WriteLine(" PARI");
                }
                else
                {
                    // dispari
                    nDispari++;
                    if (voto < 6)
                        nNegativiDispari++;
                    mediaVotiDispari += voto;
                    Console.WriteLine(" DISPARI");
                }
            }
            mediaVoti /= nStudenti;
            mediaVotiPari /= nPari;
            mediaVotiDispari /= nDispari;

            Console.WriteLine($"La media dei voti è {mediaVoti} e il numero dei voti negativi è {nNegativi}");
            Console.WriteLine($"Fila A (pari) La media dei voti è {mediaVotiPari} e il numero dei voti negativi è {nNegativiPari}");
            Console.WriteLine($"Fila B (dispari) La media dei voti è {mediaVotiDispari} e il numero dei voti negativi è {nNegativiDispari}");

        }
    }
}
