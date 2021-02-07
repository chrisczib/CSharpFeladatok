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
            Console.Write("Adja meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            int b = int.Parse(Console.ReadLine());

            //összeadás
            Console.WriteLine($"{ a} + {b} = {a + b}");
            //kivonás
            Console.WriteLine($"{ a} - {b} = {a - b}");
        }

        //Két szám kivonása
        public void FeladatA2()
        {
            Console.Write("Adja meg az első számot: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
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
            Console.Write("Adja meg a kör sugarát: ");
            int r = int.Parse(Console.ReadLine());
            double kerulet = (2 * r * Math.PI);
            double terulet = ((r * r) * Math.PI);

            Console.WriteLine("Ez a kerülete: {0:0.0000}", kerulet);
            Console.WriteLine("Ez a területe: {0:0.0000}", terulet);

        }

        //4. feladat Celsuiusban megadott értéket (°C) átvált Fahrenheitre 2 tizedes pontossággal
        public void FeladatA4()
        {
            Console.Write("Adja meg a Celsius értéket: ");
            double c = int.Parse(Console.ReadLine());
            double F = (c * 9 / 5) + 32;
            Console.WriteLine("A Celsius hőfok Fahrenheitben: {0:0.00}", F);
        }


        //5. feladat Fahrenheitben megadott értéket(°F) átvált Celsiusra 2 tizedes pontossággal.
        public void FeladatA5()
        {
            Console.Write("Adja meg a Fahrenheit értéket: ");
            double F = int.Parse(Console.ReadLine());
            double c = (F - 32) * 5 / 9;
            Console.WriteLine("A Fahrenheit hőfok Celsiusban: {0:0.00}", c);
        }

        //6.feladat bekéri egy négyzet oldalhosszát (𝑎) és kiírja a kerületét és a területét 2 tizedes pontossággal.
        public void FeladatA6()
        {
            Console.Write("Adja meg a négyzet oldalhosszát: ");
            double oldalhossz = int.Parse(Console.ReadLine());
            double kerulet = 4 * oldalhossz;
            double terulet = oldalhossz * oldalhossz;

            Console.WriteLine("A területe: {0:0.00}", terulet);
            Console.WriteLine("A kerülete: {0:0.00}", kerulet);
        }

        //7. feladat bekéri egy téglalap oldalainak (𝑎, 𝑏) a hosszúságát és kiírja a téglalap kerületét (𝐾) és területét(𝑇) 2 tizedes pontossággal!

        public void FeladatA7()
        {
            Console.Write("Adja meg a téglalap A oldalát: ");
            double A = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a téglalap B oldalát: ");
            double B = int.Parse(Console.ReadLine());
            double kerulet = 2 * (A + B);
            double terulet = A * B;

            Console.WriteLine("A területe: {0:0.00}", terulet);
            Console.WriteLine("A kerülete: {0:0.00}", kerulet);
        }

        // 8. feladat bekéri egy kocka oldalhosszúságát (𝑎) és kiírja a kocka felszínét és térfogatát 2 tizedes pontossággal!
        public void FeladatA8()
        {
            Console.Write("Adja meg a kocka oldalhosszúságát: ");
            double a = int.Parse(Console.ReadLine());
            double felszin = 6 * (a * a);
            double terulet = (a * a * a);

            Console.WriteLine("A kocka felszine: {0:0.00}", felszin);
            Console.WriteLine("A kocka területe: {0:0.00}", terulet);
        }

        //9. feladat bekéri egy téglatest oldalainak a hosszát (𝑎, 𝑏, 𝑐) és kiírja a téglatest felszínét (𝐹) és térfogatát(𝑇) 3 tizedes pontossággal.
        public void FeladatA9()
        {
            Console.Write("Adja meg a téglalap A oldalát: ");
            double A = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a téglalap B oldalát: ");
            double B = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a téglalap C oldalát: ");
            double C = int.Parse(Console.ReadLine());
            //téglatest felszine
            double felszin = (2 * A * B) + (2 * A * C) + (2 * B * C);
            //téglatest területe
            double terulet = A * B * C;

            Console.WriteLine("A téglatest felszine: {0:0.000}", felszin);
            Console.WriteLine("A téglatest területe: {0:0.000}", terulet);

        }

        //10. Feladat Kérje be egy henger sugarát (𝑟) és magasságát (𝑚), majd számítsa ki a henger felszínét (𝐹) és térfogatát(𝑇)! Az eredményt írja ki 2 tizedes pontossággal a képernyőre!
        public void FeladatA10()
        {
            Console.Write("Adja meg a henger sugarát: ");
            double r = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a henger magasságát: ");
            double m = int.Parse(Console.ReadLine());
            double felszin = 2 * Math.PI * r * (r + m);
            double terulet = Math.PI * r * m;

            Console.WriteLine("A henger felszine {0:0.00}", felszin);
            Console.WriteLine("A henger területe {0:0.00}", terulet);

        }



        //11. feladat bekér egy pénzösszeget és a legkisebb fizetőeszköznek (5 Ft) megfelelőre kerekíti.
        public void FeladatA11()
        {
            Console.Write("Adja meg az összeget: ");
            double osszeg = int.Parse(Console.ReadLine());
            double kerekitve = Math.Round(osszeg / 5.0) * 5;

            Console.WriteLine("Kerekítve {0:0.0}", kerekitve);
        }

        //12. feladat. Írjunk programot, amely bekéri „𝐴” és „𝐵” pont koordinátáit, majd kiszámolja azok távolságát
        public void FeladatA12()
        {
            Console.Write("Adja meg az A pont koordináta első részét: ");
            double a1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az A pont koordináta második részét: ");
            double a2 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a B pont koordináta első részét: ");
            double b1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a B pont koordináta második részét: ");
            double b2 = int.Parse(Console.ReadLine());
            double distance = Math.Sqrt((b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2));

            Console.WriteLine("A két koordináta közötti távolság: {0:0.0}", distance);
        
        }

        //13. feladat Egy pénztáros a napi bevételének 5%-át megkapja jutalomként. Kérje be a napi bevételt, és írja a képernyőre mennyi a jutalom! A jutalmat kerekítse egész értékre!
        public void FeladatA13()
        {
            Console.Write("Adja meg a napi bevételt: ");
            double napi = int.Parse(Console.ReadLine());
            double jutalom = napi * 0.05;
            Console.WriteLine("A napi bevételnek az 5%-a mint jutalom: {0:0}", jutalom);
        }

        //14. feladat Adott egy derékszögű háromszög a és b befogója. Határozza meg ennek ismeretében az átfogót!
        public void FeladatA14()
        {
            Console.Write("Adja meg az a befogót: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a b befogót: ");
            double b = int.Parse(Console.ReadLine());
            double atfogo = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("Az átfogó értéke: {0:0.00}", atfogo);
        }

        //15. feladat Készítsen programot, amely segít a pénztárosnak a papírpénzek értékének megszámolásánál! Kérje be melyik bankjegyből(500, 1000, 2000, 5000, 10000, 20000) hány darab van, és a végén adja meg az összes bevételt.
        public void FeladatA15()
        {
            Console.Write("Adja meg hány db 500 van: ");
            double a = int.Parse(Console.ReadLine());
            double a1 = a * 500;
            Console.Write("Adja meg hány db 1000 van: ");
            double b = int.Parse(Console.ReadLine());
            double b1 = b * 1000;
            Console.Write("Adja meg hány db 2000 van: ");
            double c = int.Parse(Console.ReadLine());
            double c1 = c * 2000;
            Console.Write("Adja meg hány db 5000 van: ");
            double d = int.Parse(Console.ReadLine());
            double d1 = d * 5000;
            Console.Write("Adja meg hány db 10000 van: ");
            double e = int.Parse(Console.ReadLine());
            double e1 = e * 10000;
            Console.Write("Adja meg hány db 20000 van: ");
            double f = int.Parse(Console.ReadLine());
            double f1 = f * 20000;
            double osszes = a1 + b1 + c1 + d1 + e1 + f1;

            Console.WriteLine("Az összes bevétel: {0:0}", osszes);
            


        }

    }
}
