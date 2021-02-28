using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Orai_Magyarazatok
{
    class listak
    {
        public void lista1()
        {
            List<string> nevek = new List<string>();
            nevek.Add("Piri");
            nevek.Add("Kati");
            nevek.Add("Feri");
            nevek.Add("Sári");
            #region később
            //beszúrás
            nevek.Insert(2, "Kiss Pista");
            #endregion
            #region még később
            //eltávolítás
            nevek.Remove("Feri");
            //vaaaaaagy
            nevek.RemoveAt(1);
            #endregion
            #region sokkal később
            //törlés
            nevek.Clear();
            #endregion

            for (int i = 0; i < nevek.Count; i++)
            { Console.WriteLine(nevek[i] + " "); }
            Console.ReadKey();
        }

        //napló feladat
        public void lista2()
		{
            List<string> nevsor = new List<string>();
            bool go = true;
            
            while (go)
			{
                Console.WriteLine("Műveletek:");
                Console.WriteLine("1 - Névsor kiírása");
                Console.WriteLine("2 - Új diák felvétel");
                Console.WriteLine("3 - Diák törlése");
                Console.WriteLine("0 - Kilépés");
                Console.Write("Adjon meg egy számot: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("1 - Névsor kiírása");
                        break;
                    case 2:
                        Console.WriteLine("2 - Új diák felvétel");
                        break;
                    case 3:
                        Console.WriteLine("3 - Diák törlése");
                        break;
                    case 0:
                        Console.WriteLine("0 - Kilépés");
                        go = false;
                        break;
                    default:
                        break;
                }
				if (input == 1)
				{
                    nevsor.Sort();
					foreach (var name in nevsor)
					{
                        Console.WriteLine(name);
                    }
				}
				else if (input == 2)
				{
                    string nev = Console.ReadLine();
                    nevsor.Add(nev);
				}
				else if (input == 3)
				{
					Console.WriteLine("Adja meg a diák nevét: ");
                    string diakneve = Console.ReadLine();
                    nevsor.Remove(diakneve);
					Console.WriteLine("A diák törölve a rendszerből!");
				}

            }

        }

        public void lista3()
		{
            /*
              Az első részben létre kell hozni egy 10 elemű tömböt. Megvizsgálni, hogy vannak-e benne páros számok, ha vannak, akkor azokat átmásolni egy tömbbe és egy listába.
                A második rész ennek analógiájára:
                Létre kell hozni egy 10 elemű listát, megvizsgálni, hogy vannak-e benne páros számok, ha vannak, akkor azokat átmásolni egy tömbbe és egy listába.
             */
            Random rnd = new Random();
 
            //Első rész
            int darab = 10;
            int[] tombOG = new int[darab];
            int[] tombParos = new int[darab];
            List<int> listaparos = new List<int>();
            for (int i = 0; i < tombOG.Length; i++)
            {
                int randomint = rnd.Next(10000);
                tombOG[i] = randomint;
				//Console.WriteLine("TombOG: " + tombOG[i]);
				if (tombOG[i] % 2 == 0)
				{
                    tombParos[i] += tombOG[i];
                    listaparos.Add(tombOG[i]);
                }
                Console.WriteLine("tombparos: " + tombParos[i]);
            }
            listaparos.ForEach(Console.WriteLine);
            
            //Második rész
            List<int> listaOG = new List<int>(darab);
            int[] tombParos2 = new int[darab];
            List<int> listaParos2 = new List<int>(darab);
			for (int i = 0; i < 10; i++)
			{
                listaOG.Add(rnd.Next(10000));
				if (listaOG[i] % 2 == 0)
				{
                    listaParos2.Add(listaOG[i]);
                    tombParos2[i] += listaOG[i];
				}
                Console.WriteLine("tombParos2: " + tombParos2[i]);
			}
            listaOG.ForEach(Console.WriteLine);

        }

    }

}
