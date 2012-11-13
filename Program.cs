using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoLotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            byte[] numery = new byte[6];
            int index = 0;
            int i;
            bool flaga;
            do
            {
                numery[index] = (byte)r.Next(1, 50);
                flaga = true;
                for (i = 0; i < index; i++)
                {
                    if (numery[index] == numery[i])
                    {
                        flaga = false;
                        break;
                    }
                }
                if (flaga)
                {
                    index++;
                }
            }
            while (index < 6);
            Console.WriteLine("Wylosowane liczby to:");
            foreach (int numer in numery)
            {
                Console.WriteLine("{0}, ", numer);
            }
            Console.ReadKey(true);
        }
    }
}
