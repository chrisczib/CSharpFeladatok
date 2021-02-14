using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.HeroGameDir
{
	class throwaway
	{
		Random rnd = new Random();

		//Miss chance properties
		bool miss = false;
		int missHit = 0;
		int attackDamage = 0;

		public void missChance()
		{
			attackDamage = rnd.Next(6, 9);
			missHit = rnd.Next(1, 101);

			if (missHit <= 20)
			{
				miss = true;
				attackDamage = 0;
			}
			else
			{
				miss = false;
			}
			Console.WriteLine("Number of the miss random generator: {0}",missHit);
			Console.WriteLine("Is miss true or false? {0}",miss);
			Console.WriteLine("Attack damage: {0}",attackDamage);

		}




	}
}
