using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Orai_Magyarazatok
{
	class tombok3
	{
		// Február 17
        // part 1
		public void tombokFeladat3()
		{
            Random rng = new Random();
            int[] tomb = new int[5];
            int seged = 0;
            int j = 0;
            bool mehet = true;
            for (int i = 0; i < tomb.Length; i++)
            {
                seged = rng.Next(1, 6);
                Console.WriteLine(seged);
                j = 0;
                mehet = true;
                while (j < i && mehet == true)
                {
                    if (tomb[j] == seged)
                    {
                        mehet = false;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (mehet == true)
                {
                    tomb[i] = seged;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

        }
        // part 2 
        public void tombokFeladat4()
		{
            Random rng = new Random();
            int[] tomb = new int[5];
            int seged = 0;
            int j = 0;
            bool mehet = true;
            for (int i = 0; i < tomb.Length; i++)
            {
                seged = rng.Next(1, 6);
                j = 0;
                mehet = true;
                while (j < i && mehet == true)
                {
                    if (tomb[j] == seged)
                    {
                        mehet = false;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (mehet == true)
                {
                    tomb[i] = seged;
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            for (int i = 0; i < tomb.Length - 1 / (4) ; i++)
            {
                for (int k = i + 1; k < tomb.Length / (5) ; k++)
                {
                    if (tomb[i] > tomb[k])
                    {
                        int s = tomb[i];
                        tomb[i] = tomb[k];
                        tomb[k] = s;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

        }
        // part 3
        public void tombokFeladat5()
		{
            int[] a = new int[5];
            int i = 0, j = 0;
            bool csere = false;
            Random vsz = new Random();
            for (i = 0; i < 5; i++)
            {
                a[i] = vsz.Next(1, 101);
                Console.WriteLine(a[i]);

            }
            Console.WriteLine("hello");
            do
            {
                csere = false;
                for (i = 0; i < 4; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int s = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = s;
                        csere = true;
                    }
                }
            } while (csere == true);


            for (i = 0; i < 5; i++)
            {

                Console.WriteLine(a[i]);

            }
            Console.ReadKey();
        }



    }
}
