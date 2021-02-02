using System;
using LibreriaArray;
namespace Array2N
{
    class Program
    {
        const int dimensione = 5;
        static void Main(string[] args)
        {
            int[] vettore1 = new int[dimensione];
            int[] vettore2 = new int[dimensione];
            int[] vettore3 = new int[dimensione * 2];
            Console.WriteLine("Inserisci elementi del primo vettore: ");
            Gestione.LeggiArry(vettore1);
            Console.WriteLine("Inserisci elementi del secondo vettore: ");
            Gestione.LeggiArry(vettore2);
            for(int i = 0, j = 0, k = 0; i < vettore3.Length; i++)
            {
                if(i % 2 != 0)
                {
                    vettore3[i] = vettore2[j];
                    j++;
                }
                else
                {
                    vettore3[i] = vettore1[k];
                    k++;
                }
            }
            Console.WriteLine("Gli elementi del vettore 3 sono: ");
            Gestione.StampaArray(vettore3);
        }
    }
}
