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
	}
}
/*
          

Console.WriteLine("műveletek");

Napló feladat:
                Console.WriteLine("1 ha kiíratod a névsort");
                Console.WriteLine("2 ha új diákot veszel fel");
                Console.WriteLine("3 diák törlése");
                Console.WriteLine("0 kilépés");
nevek.Sort();












2: feladat
2 listám 2 tömb
1 lista 1 tömb rendelkezik adatokkal
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */