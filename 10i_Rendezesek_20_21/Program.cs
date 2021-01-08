using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10i_Rendezesek_20_21
{
    class Program
    {
        static void MinimumkivalasztasosRendezes(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                int legkisebb = i;
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[legkisebb] > t[j])
                    {
                        legkisebb = j;
                    }
                }

                if (i != legkisebb)
                {
                    int seged = t[i];
                    t[i] = t[legkisebb];
                    t[legkisebb] = seged;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] tomb = new int[3];
            Random random = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 101);
            }
            Console.WriteLine("A rendezetlen tomb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            MinimumkivalasztasosRendezes(tomb);

            Console.WriteLine("A rendezett tomb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            Console.ReadKey();
        }
    }
}
