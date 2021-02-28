using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Orai_Dolgozat
{
    class oraidolgozat
    {
        Random rnd = new Random();
        public void oraiFeladat()
        {
            //1; feladat: hozz létre egy 20 elemű, egész típusú tömböt ,,eredmenyek" néven.
            int[] eredmenyek = new int[20];

            //2; feladat: hozz létre egy 20 elemű, szöveg típusú tömböt ,,nevek" néven.
            string[] nevek = new string[20];

            // 3; feladat: hozz létre egy 20 elemű, szöveg típusú tömböt ,,nemzet" néven.
            string[] nemzet = new string[20];

            //TODO 4; feladat: Az ,,eredmenyek" tömböt töltse fel 250 és 350 közötti értékekkel, úgy hogy 2 ugyanolyan ne fordulhasson elő benne.
            for (int i = 0; i < eredmenyek.Length; i++)
            {
                int randomint = rnd.Next(250, 351);
                if (!eredmenyek.Contains(randomint))
                {
                    eredmenyek[i] = randomint;
				}
            }
            nevek[0] = "Analfabéta Aladár";
            nevek[1] = "Békési Béla";
            nevek[2] = "Cifra Cecilia";
            nevek[3] = "Dobogó Dénes";
            nevek[4] = "Erős Ernő";
            nevek[5] = "Farkas Flórián";
            nevek[6] = "Gárdonyi Géza";
            nevek[7] = "Gyári Gyula";
            nevek[8] = "Holló Hedvig";
            nevek[9] = "Illedelmes Ilona";
            nevek[10] = "Jámbor Jácint";
            nevek[11] = "Könyves Kálmán";
            nevek[12] = "Lapos Lajos";
            nevek[13] = "Mai Márton";
            nevek[14] = "Neves Nóra";
            nevek[15] = "Ordas Olga";
            nevek[16] = "Pedáns Péter";
            nevek[17] = "Retek Roland";
            nevek[18] = "Sebes Sándor";
            nevek[19] = "Száguldó Szilvia";

            nemzet[0] = "HUN";
            nemzet[1] = "ENG";
            nemzet[2] = "SWE";
            nemzet[3] = "HUN";
            nemzet[4] = "HUN";
            nemzet[5] = "ENG";
            nemzet[6] = "GER";
            nemzet[7] = "POL";
            nemzet[8] = "HUN";
            nemzet[9] = "POL";
            nemzet[10] = "ENG";
            nemzet[11] = "GER";
            nemzet[12] = "HUN";
            nemzet[13] = "FRA";
            nemzet[14] = "ENG";
            nemzet[15] = "HUN";
            nemzet[16] = "GER";
            nemzet[17] = "FRA";
            nemzet[18] = "HUN";
            nemzet[19] = "FRA";

            //5; feladat: írassa ki a 3 tömb adatait "nevek""nemzet""eredmenyek" sorrendben és 1 sorban szerepeljenek az összidő szerint csökkenő sorrendben..
            Array.Sort(eredmenyek);
            Array.Reverse(eredmenyek);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0} {1} {2}",nevek[i], nemzet[i], eredmenyek[i]);
            }

            //6; feladat: írassa ki a versenyzők összidejét.
            int osszido = eredmenyek.Sum();
			Console.WriteLine("Összidő: " +osszido);

            //7; feladat: írassa ki az átlag versenyidőt.
            int atlag = osszido / eredmenyek.Length;
			Console.WriteLine("Átlag idő: " + atlag);

            //8; feladat: írassa ki a leggyorsabb versenyző nevét és eredményét.
            Console.WriteLine("Leggyorsabb versenyző: " + eredmenyek[19]);

            //9; feladat: írassa ki a leglassabb versenyző nevét és eredményét.
            Console.WriteLine("Leglassabb versenyző: " + eredmenyek[0]);

			//10; feladat: írassa ki azon versenyzők nevét és eredményét akik átlag alatti idővel teljesítették a pályát.
			for (int i = 0; i < eredmenyek.Length; i++)
			{
                if (eredmenyek[i] < atlag)
                {
                    Console.WriteLine("Átlag alatti versenyzők: " + nevek[i] + " " + eredmenyek[i]);
                }
            }

            //11; feladat: Hanyadik helyen szerepel "Zelk Zoltán" (amennyiben a keresett név nem szerepel a névsorban azt írassa ki).
            string target = "Zelk Zoltán";
            int index = Array.FindIndex(nevek, item => item == target);
			if (index < 0)
			{
				Console.WriteLine("A név nem szerepel a névsorban!");
			}
			else
			{
                Console.WriteLine(index);
			}

            //12; feladat: Hanyadik helyen szerepel "Jámbor Jácint" (amennyiben a keresett név nem szerepel a névsorban azt írassa ki).
            string target2 = "Jámbor Jácint";
            int index1 = Array.FindIndex(nevek, item => item == target2);
            if (index1 < 0)
            {
                Console.WriteLine("A név nem szerepel a névsorban!");
            }
            else
            {
                Console.WriteLine(index1);
            }

            //13; feladat: írassa ki hány darab "HUN"- nemzetíségű versenyző indult a versenyen.
            int counter = 0;
            for (int i = 0; i < nemzet.Length; i++)
			{
				if (nemzet[i] == "HUN")
				{
                    counter++;
				}
			}
			Console.WriteLine("Magyar versenyzők létszáma: " + counter);

            // TODO 14: duplikáció szűrés


            // TODO 15: rendezés a legenerált tömbben.





        }
    }
}
  

