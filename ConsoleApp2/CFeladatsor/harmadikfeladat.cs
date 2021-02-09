using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2.CFeladatsor
{
    class harmadikfeladat
    {

        //1. kiírja 10 és 20 között az egész számokat.
        public void FeladatC1()
        {
            int a = 10;
            int c = 0;

            while (c != 10)
            {
                Console.WriteLine(a);
                a++;
                c++;
            }
        }


        //2. kiírja 10 és 30 között a páros számokat
        public void FeladatC2()
        {
            int a = 10;
            int b = 0;
            while (b < 20)
            {
                int c = a % 2;
                if (c == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
                b++;
            }
        }

        //3. bekér két számot és kiírja kettő közötti páros számokat!
        public void FeladatC3()
        {
            Console.Write("Adja meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            int b = int.Parse(Console.ReadLine());

            
            while (a < b)
            {
                int c = a % 2;
                if (c == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
        }

        //4. Készítsünk programot, amely 15 darab ’*’-ot ír ki a képernyőre egy sorba!
        public void FeladatC4()
        {
            int a = 0;
            while (a < 15 + 0)
            {
                Console.Write("*");
                a++;
            }
        }

        //5. Írassa ki a számokat 1-től 20-ig és mellé a négyzetüket is!
        public void FeladatC5()
        {
            int a = 1;
            while (a < 20 + 1)
            {
                Console.Write(" {0:0} ",a);
                Console.WriteLine(" {0:0} ", a * a);
                a++;
            }
        }
        //6. bekér egy számot és kiírja az összes osztóját! 
        public void FeladatC6()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            int b = 1;

            while (b < a+1)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);               
                } 
                b++;
            }
        }
        //7. Írassa ki 99-től csökkenő sorrendben az összes pozitív, 3-al osztható pozitív egész számot!
        public void FeladatC7()
        {
            int a = 99;
            while (a > 0 & a < 100)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
                a--;
            }
        }

        //8. addig kér be egész számokat, amíg nullát nem kap. Ekkor kiírja, hogy „elég” és megáll
        public void FeladatC8()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
           
            while (a != 0)
            {
                Console.WriteLine("Adjon meg egy számot: ");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
				{
                    a = 0;
				}
                
            }
        }

        //9. bekér egy számot és kiírja a faktoriálisát
        //A feladatok megoldásánál CSAK a ciklusok gyakorlása a cél, nem kell optimalizálni a megoldásokat!
        public void FeladatC9()
        {
            Console.Write("Adjon meg egy faktoriális számot: ");
            int a = int.Parse(Console.ReadLine());
            long b = a;

            while (a > 1)
            {
                b *= --a;

            }
            Console.WriteLine("A faktoriális összege: {0:0}",b);
        }

        //10. bekér egy számot és kiírja a megadott szám osztóit, illetve, hogy az adott számnak hány osztója van 1-en és önmagán kívül.

        public void FeladatC10()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 0;

            while (b < a)
            {
                if (a % b == 0 & b != 1)
                {
                    Console.WriteLine(b);
                    c++;
                }
                b++;
            }
            Console.WriteLine("A számnak ennyi osztója van: {0:0}", c);
        }

        //11. bekér egy számot és kiírja, hogy prím-e.

        public void FeladatC11()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 1;

            while (b != a)
            {
                if (a % b == 0)
				{
                    c++;
				}
                b++;
            }
            if (c == 2)
            {
                Console.WriteLine("A szám prím szám.");
            }
            else
            {
                Console.WriteLine("A szám nem prím szám.");
            }
            
        }

        //12. bekér két számot és kiírja a legnagyobb közös osztót. NOTDONE
        public void FeladatC12()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 0;
            int largestOsztoA = 0;
            int largestOsztoB = 0;

            while (b < a)
            {
                if (a % b == 0 & b != 1 & b != a)
                {
                    Console.WriteLine(b);
                    c++;
                }
                
                b++;
            }
			if (c == 100 - 1)
			{
                largestOsztoA = b;
			}

            Console.WriteLine("{0:0}", largestOsztoA);
            Console.WriteLine("A számnak ennyi osztója van: {0:0}", c);

        }

        //13. bekér két számot és kiírja a legkisebb közös többszöröst. NOTDONE
        //14. Készítsen programot, ami számokat kér be addig, míg az utolsó két szám meg nem egyezik!
        public void FeladatC14()
		{
            int a = 0;
            int b = 1;

			while (a != b)
			{
                Console.Write("Adja meg az első számot: ");
                int c = int.Parse(Console.ReadLine());
                a = c;
                Console.Write("Adja meg a második számot: ");
                int d = int.Parse(Console.ReadLine());
                b = d;
            }

		}

        //15. A gép véletlenszerűen találjon ki egy számot 1 és 100 között! A felhasználótól kérjen be tippeket, és mondja meg, hogy a gondolt szám a tipptől nagyobb-e vagy kisebb! A tippelés addig megy, amíg a felhasználó el nem találta a megadott számot.
        public void FeladatC15()
		{
            Random random = new Random();
            int a = random.Next(1,101);
            int b = 0;


            while (a != b)
			{
                Console.WriteLine("Tippeljen egy számot: ");
                b = int.Parse(Console.ReadLine());
				if (b > a)
				{
                    Console.WriteLine("A tipp nagyobb mint a kitalálandó szám!");
				}
				else if (b < a)
				{
                    Console.WriteLine("A tipp kisebb mint a kitalálandó szám!");
				}
				{

				}

			}

		}

        //16. Bővítse az előző feladatot úgy, hogy a szám eltalálásakor írja ki hány tippelésből sikerült eltalálni a számot!
        public void FeladatC16()
        {
            Random random = new Random();
            int a = random.Next(1, 101);
            int b = 0;
            int c = 1;

            while (a != b)
            {
                Console.WriteLine("Tippeljen egy számot: ");
                b = int.Parse(Console.ReadLine());
                if (b > a)
                {
                    Console.WriteLine("A tipp nagyobb mint a kitalálandó szám!");
                    c++;
                }
                else if (b < a)
                {
                    Console.WriteLine("A tipp kisebb mint a kitalálandó szám!");
                    c++;
				}
				else if (a == b)
				{
                    Console.WriteLine("Ennyi tippbe került kitalálni: {0:0}", c);
				}
                {

                }

            }

        }

        //17. Készítsünk programot, amely az első sorba kiír 15 *-ot, a másodikba 14 *-ot, …, a tizennegyedik sorba 2 *-ot, a tizenötödik sorba pedig 1*-ot! A csillagok kiírása a sor elején kezdődjön!
        public void FeladatC17()
		{
            string stars = "";

			for (int i = 16; i > 1; i--)
			{
                for (int j = 1; j < i; j++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
            }
            
           
            
		}















        //18. Készítse el az előző feladatot úgy, hogy a 2. sortól kezdődően a *-ok jobbra legyenek igazítva, az első sor utolsó csillagához!

    }
}
