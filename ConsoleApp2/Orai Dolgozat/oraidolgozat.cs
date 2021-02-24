using System;

namespace ConsoleApp2.Orai_Dolgozat
{
    class oraidolgozat
    {
        Random rnd = new Random();
        public void oraiFeladat()
        {
            int[] eredmenyek = new int[20];
            string[] nevek = new string[20];
            string[] nemzet = new string[20];
            //int randomint = rnd.Next(250, 350);
            for (int i = 0; i < eredmenyek.Length; i++)
            {
                int randomint = rnd.Next(250, 351);
                eredmenyek[i] = randomint;
                Console.WriteLine(eredmenyek[i]);
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


        }
    }
}
    /*
     * A következő feladatban egy autóversenyen indulók adataival kell dolgoznia.
     1; feladat: hozz létre egy 20 elemű, egész típusú tömböt ,,eredmenyek" néven.
     2; feladat: hozz létre egy 20 elemű, szöveg típusú tömböt ,,nevek" néven.
     3; feladat: hozz létre egy 20 elemű, szöveg típusú tömböt ,,nemzet" néven.
     TODO 4; feladat: Az ,,eredmenyek" tömböt töltse fel 250 és 350 közötti értékekkel, úgy hogy 2 ugyanolyan ne fordulhasson elő benne.
     TODO 5; feladat: írassa ki a 3 tömb adatait "nevek""nemzet""eredmenyek" sorrendben és 1 sorban szerepeljenek az összidő szerint csökkenő sorrendben..
     TODO 6; feladat: írassa ki a versenyzők összidejét.
     TODO 7; feladat: írassa ki az átlag versenyidőt.
     TODO 8; feladat: írassa ki a leggyorsabb versenyző nevét és eredményét.
     TODO 9; feladat: írassa ki a leglassabb versenyző nevét és eredményét.
    TODO 10; feladat: írassa ki azon versenyzők nevét és eredményét akik átlag alatti idővel teljesítették a pályát.
    TODO 11; feladat: Hanyadik helyen szerepel "Zelk Zoltán" (amennyiben a keresett név nem szerepel a névsorban azt írassa ki).
    TODO 12; feladat: Hanyadik helyen szerepel "Jámbor Jácint" (amennyiben a keresett név nem szerepel a névsorban azt írassa ki).
    TODO 13; feladat: írassa ki hány darab "HUN"- nemzetíségű versenyző indult a versenyen.
    TODO 14: duplikáció szűrés
    TODO 15: rendezés a legenálrt tömbben.
     */

