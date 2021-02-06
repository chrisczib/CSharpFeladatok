using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.AFeladatsor
{
    public class elsoFeladat
    {
        //1. Két szám összeadása
        public void FeladatA1()
        {
            Console.WriteLine("Adja meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot: ");
            int b = int.Parse(Console.ReadLine());

            //összeadás
            Console.WriteLine($"{ a} + {b} = {a + b}");
            //kivonás
            Console.WriteLine($"{ a} - {b} = {a - b}");
        }

        //Két szám kivonása
        public void FeladatA2()
        {
            Console.WriteLine("Adja meg az első számot: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot: ");
            double b = int.Parse(Console.ReadLine());
            double szorzas = a * b;
            double hanyados = a / b;

            //szorzás
            Console.WriteLine("{0:0.00}", szorzas);
            //osztás
            Console.WriteLine("{0:0.00}", hanyados);

        }
        //3. Feladat, bekér egy kör sugarát és kiírja a kerületét és területét 
        // 4 tizedes pontossággal. 
        public void FeladatA3()
        {
            Console.WriteLine("Adja meg a kör sugarát: ");
            int r = int.Parse(Console.ReadLine());
            double kerulet = (2 * r * Math.PI);
            double terulet = ((r * r) * Math.PI);

            Console.WriteLine("Ez a kerülete: {0:0.0000}", kerulet);
            Console.WriteLine("Ez a területe: {0:0.0000}", terulet);

        }

        //4. feladat Celsuiusban megadott értéket (°C) átvált Fahrenheitre 2 tizedes pontossággal
        public void FeladatA4()
        {
            Console.WriteLine("Adja meg a Celsius értéket: ");
            double c = int.Parse(Console.ReadLine());
            double F = (c * 9 / 5) + 32;
            Console.WriteLine("A Celsius hőfok Fahrenheitben: {0:0.00}", F);
        }


        //5. feladat Fahrenheitben megadott értéket(°F) átvált Celsiusra 2 tizedes pontossággal.
        public void FeladatA5()
        {
            Console.WriteLine("Adja meg a Fahrenheit értéket: ");
            double F = int.Parse(Console.ReadLine());
            double c = (F - 32) * 5 / 9;
            Console.WriteLine("A Fahrenheit hőfok Celsiusban: {0:0.00}", c);
        }

        //6.feladat bekéri egy négyzet oldalhosszát (𝑎) és kiírja a kerületét és a területét 2 tizedes pontossággal.
        public void FeladatA6()
        {
            Console.WriteLine("Adja meg a négyzet oldalhosszát");
            double oldalhossz = int.Parse(Console.ReadLine());
            double kerulet = 4 * oldalhossz;
            double terulet = oldalhossz * oldalhossz;

            Console.WriteLine("A területe: {0:0.00}", terulet);
            Console.WriteLine("A kerülete: {0:0.00}", kerulet);
        }

        //7. feladat bekéri egy téglalap oldalainak (𝑎, 𝑏) a hosszúságát és kiírja a téglalap kerületét (𝐾) és területét(𝑇) 2 tizedes pontossággal!

        public void FeladatA7()
        {
            Console.WriteLine("Adja meg a téglalap A oldalát");
            double A = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a téglalap B oldalát");
            double B = int.Parse(Console.ReadLine());
            double kerulet = 2 * (A + B);
            double terulet = A * B;

            Console.WriteLine("A területe: {0:0.00}", terulet);
            Console.WriteLine("A kerülete: {0:0.00}", kerulet);
        }

        // 8. feladat bekéri egy kocka oldalhosszúságát (𝑎) és kiírja a kocka felszínét és térfogatát 2 tizedes pontossággal!
        public void FeladatA8()
        {
            Console.WriteLine("Adja meg a kocka oldalhosszúságát");
            double A = int.Parse(Console.ReadLine());
            double felszin = 6 * (A * A);
            double terulet = (A * A * A);

            Console.WriteLine("A kocka felszine: {0:0.00", felszin);
            Console.WriteLine("A kocka területe: {0:0.00", terulet);
        }
    }
}
