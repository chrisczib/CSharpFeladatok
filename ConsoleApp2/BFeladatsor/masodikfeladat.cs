using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.BFeladatsor
{
    class masodikfeladat
    {
        // 1. bekér egy számot és kiírja, hogy páros vagy páratlan.
        public void FeladatB1()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }

        }

        //2. bekér a felhasználótól egy számot, majd kiírja az adott számról, hogy páros, páratlan, vagy nulla.
        public void FeladatB2()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("A szám páratlan");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("A szám nulla");
            }

        }

        //3. egy tetszőleges számról mondjuk meg, hogy osztható-e maradék nélkül 3-mal!
        public void FeladatB3()
        {
            Console.Write("Adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-al maradék nélkül.");
            } else if (a % 3 != 0)
            {
                Console.WriteLine("A szám nem osztható 3-al maradék nélkül. A maradék: {0:0}", a % 3);
            }
        }

        // 4. bekér két számot és a nagyobból kivonja a kisebbet. Az eredményt kiírja a képernyőre.
        public void FeladatB4()
        {
            Console.Write("Adja meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int c = a - b;
                Console.WriteLine("Az eredmény: {0:0}", c);
            }
            else if (a < b)
            {
                int c = b - a;
                Console.WriteLine("Az eredmény: {0:0}", c);
            }


        }

        //5. Kérjen be 2 számot és a nagyobbat ossza el a kisebbel! Az eredményt 2 tizedesjegy pontossággal írja ki! (Nullával nem lehet osztani!)
        public void FeladatB5()
        {
            Console.Write("Adja meg az első számot: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            double b = int.Parse(Console.ReadLine());
            if (a == 0 ^ b == 0) {
                Console.WriteLine("A szám nem lehet nulla!");
            }
            else if (a > b)
            {
                double c = a / b;
                Console.WriteLine("Az eredmény: {0:0.00}", c);
            } else if (a < b)
            {
                double c = b / a;
                Console.WriteLine("Az eredmény: {0:0.00}", c);
            }
        }

        //6. bekér a felhasználótól két számot. A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám.Írja ki az osztás eredményét is
        public void FeladatB6()
        {
            Console.Write("Adja meg az első számot: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második számot: ");
            double b = int.Parse(Console.ReadLine());

            if (b % a == 0)
            {
                double c = b / a;
                Console.WriteLine("Az első szám osztója a másodiknak. Az eredmény: {0:0}", c);
            }
            else
            {
                Console.WriteLine("Az első szám nem osztója a másodiknak.");
            }

        }

        //7. bekéri egy háromszög oldalainak a hosszát és kiírja, hogy szerkeszthető-e.
        public void FeladatB7()
        {
            Console.Write("Adja meg az első oldalt: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második oldalt: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a harmadik oldalt: ");
            double c = int.Parse(Console.ReadLine());

            if (c > (a + b))
            {
                Console.WriteLine("A háromszög szerkeszthető.");
            } else if (c < (a + b))
            {
                Console.WriteLine("A háromszög nem szerkeszthető.");
            }
        }

        //8. bekéri a hét napjának számát és kiírja a hét napját szöveggel (1 -> hétfő)
        public void FeladatB8()
        {
            Console.Write("Adja meg a hét napjának számát: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("A hét napja hétfő.");
            }
            else if (a == 2)
            {
                Console.WriteLine("A hét napja kedd.");
            }
            else if (a == 3)
            {
                Console.WriteLine("A hét napja szerda.");
            }
            else if (a == 4)
            {
                Console.WriteLine("A hét napja csütörtök.");
            }
            else if (a == 5)
            {
                Console.WriteLine("A hét napja péntek.");
            }
            else if (a == 6)
            {
                Console.WriteLine("A hét napja szombat.");
            }
            else if (a == 7)
            {
                Console.WriteLine("A hét napja vasárnap.");
            }
            

        }

        //9. bekéri a hónap számát és kiírja szövegesen (6 -> június)
        public void FeladatB9()
        {
            Console.Write("Adja meg a hónap számát: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Január.");
            }
            else if (a == 2)
            {
                Console.WriteLine("Február.");
            }
            else if (a == 3)
            {
                Console.WriteLine("Március.");
            }
            else if (a == 4)
            {
                Console.WriteLine("Április.");
            }
            else if (a == 5)
            {
                Console.WriteLine("Május.");
            }
            else if (a == 6)
            {
                Console.WriteLine("Június.");
            }
            else if (a == 7)
            {
                Console.WriteLine("Július.");
            }
            else if (a == 8)
            {
                Console.WriteLine("Augusztus.");
            }
            else if (a == 9)
            {
                Console.WriteLine("Szeptember.");
            }
            else if (a == 10)
            {
                Console.WriteLine("Október.");
            }
            else if (a == 11)
            {
                Console.WriteLine("November.");
            }
            else if (a == 12)
            {
                Console.WriteLine("December.");
            }

        }


        //10. Készítsünk programot, amely bekéri a víz hőmérsékletét, majd eldönti, hogy az milyen halmazállapotú.A halmazállapot lehet folyékony, gőz, vagy jég.
        public void FeladatB10()
        {
            Console.Write("Adja meg a víz hőmérsékletét: ");
            int a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("A víz halmazállapota: jég");
            }
            else if (a > 0 & a < 100)
            {
                Console.WriteLine("A víz halmazállapota: folyékony");
            }else if (a >= 100)
            {
                Console.WriteLine("A víz halmazállapota: gőz");
            }
        }

        //11. Írjon egy programot, ami leosztályoz (betűvel és számmal) egy maximálisan 100 pontos dolgozatot az 50, 65, 80, 90 ponthatárok szerint! A határérték a jobb jegyhez tartozik.Ha a pontszám negatív vagy száznál nagyobb, akkor a program írja ki, hogy hibás az adat!
        public void FeladatB11()
        {
            Console.Write("Adja meg a dolgozat eredményét: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 100 ^ a < 0)
            {
                Console.WriteLine("Hibás adat!");
            } else if (a < 50 & a > 0)
            {
                Console.WriteLine("Az osztályzat 1-es");
            } else if (a < 65 & a >= 50)
            {
                Console.WriteLine("Az osztályzat 2-es");
            } else if (a < 80 & a >= 65)
            {
                Console.WriteLine("Az osztályzat 3-as");
            } else if (a < 90 & a >= 80)
            {
                Console.WriteLine("Az osztályzat 4-es");
            } else if (a <=100 & a >= 90)
            {
                Console.WriteLine("Az osztályzat 5-ös");
            }
        }


        //12. Az előző feladatot úgy oldja meg, hogy a jegyet számszerűen és szövegesen is írja ki! (1– elégtelen, 2 – elégséges, 3 – közepes, 4 – jó, 5 – kitűnő)
        public void FeladatB12()
        {
            Console.Write("Adja meg a dolgozat eredményét: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 100 ^ a < 0)
            {
                Console.WriteLine("Hibás adat!");
            }
            else if (a < 50 & a > 0)
            {
                Console.WriteLine("1 - elégtelen");
            }
            else if (a < 65 & a >= 50)
            {
                Console.WriteLine("2 - elégséges");
            }
            else if (a < 80 & a >= 65)
            {
                Console.WriteLine("3 - közepes");
            }
            else if (a < 90 & a >= 80)
            {
                Console.WriteLine("4 - jó");
            }
            else if (a <= 100 & a >= 90)
            {
                Console.WriteLine("5 - kitűnő");
            }
        }

        //.13. A program bekéri egy tetszőleges pont koordinátáit és kiírja
        /*melyik síknegyedben van!
            + és + → Első síknegyed
            - és + → Második síknegyed
            - és - → Harmadik síknegyed
            + és - → Negyedik síknegyed
        */
        public void FeladatB13()
        {
            Console.Write("Adja meg az első koordináta pontot 'x': ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a második koordináta pontot 'y': ");
            int y = int.Parse(Console.ReadLine());
            if (x == 0 & y == 0)
            {
                Console.WriteLine("A koordináta középen helyeszkedik el");
            }else if (x > 0 & y > 0)
            {
                Console.WriteLine("A koordináta az első síknegyedben helyeszkedik el");
            }else if (x < 0 & y > 0)
            {
                Console.WriteLine("A koordináta az második síknegyedben helyeszkedik el");
            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine("A koordináta az harmadik síknegyedben helyeszkedik el");
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine("A koordináta az negyedik síknegyedben helyeszkedik el");
            }
        }


    }
}
