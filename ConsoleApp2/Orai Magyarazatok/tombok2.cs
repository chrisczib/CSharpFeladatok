using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Orai_Magyarazatok
{
	class tombok2
	{
		//Február 10 Part2
		public void tombokFeladat2()
		{
            Console.WriteLine("hány elemű a tömb??");
            int darab = Convert.ToInt32(Console.ReadLine());
            Random rng = new Random();
            int[] tomb = new int[darab];
            int osszeg = 0;
            int atlag = 0;
            int min = 101;
            int minhely = 0;
            int max = 0;
            int maxhely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rng.Next(1, 101);
                Console.WriteLine(tomb[i]);
                osszeg = osszeg + tomb[i];
            }
            atlag = osszeg / tomb.Length;
            Console.WriteLine("a tömb elemeinek összege: {0}", osszeg);
            Console.WriteLine("a tömb elemeinek átlaga: {0}", atlag);
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max < tomb[i])
                {
                    max = tomb[i];
                    maxhely = i + 1;
                }
            }
            Console.WriteLine("a legnagyobb elem: {0}", max);
            Console.WriteLine("helye: {0}", maxhely);
            for (int i = 0; i < tomb.Length; i++)
            {
                if (min > tomb[i])
                {
                    min = tomb[i];
                    minhely = i + 1;
                }
            }
            Console.WriteLine("a legkisebb elem: {0}", min);
            Console.WriteLine("helye: {0}", minhely);
            Console.WriteLine();
            int szamlal = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    Console.WriteLine(tomb[i]);
                    szamlal++;
                }
            }
            Console.WriteLine("A PÁROS SZÁMOKBÓL {0} darab van", szamlal);
        }
	}
}
