using System;

namespace LibreriaArray
{
    public class Gestione
    {
        public static void LeggiArry(int[] array)
        {
            for (int i = 0; i < array.Length && array[i] >= 0; i++)
            {
                Console.WriteLine($"Inserisci {i + 1}° elemento: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }   
        }
        public static void StampaArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
