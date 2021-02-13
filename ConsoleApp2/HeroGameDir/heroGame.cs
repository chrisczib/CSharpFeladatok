using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.HeroGameDir
{
	class heroGame
	{
		Random rnd = new Random();

		public void mainGamePlay()
		{
			//Hero stats
			string heroName = "hero";
			int heroHP = 60;
			int heroHit = rnd.Next(6, 9); //between 6-8(6,7,8)
			int heroNum = 0;

			//Villain stats
			string villainName = "villain";
			int villainHP = 70;
			int villainHit = rnd.Next(5, 8); //between 5-7(5,6,7)
			int villainNum = 0;

			//Gameplay stats
			int gameRound = 1;
			string whoHits = "";
			bool critical = false;
			int criticalHit = 0;
			bool miss = false;
			int missHit = 0;
			string firstHit = "";



			while (gameRound < 2 + 1)
			{
				//first hit calculator
				if (gameRound == 1)
				{
					heroNum += rnd.Next(1, 101);
					villainNum += rnd.Next(1, 101);
					Console.WriteLine("hero number: {0}", heroNum);
					Console.WriteLine("villain number: {0}", villainNum);
					if (heroNum > villainNum)
					{
						whoHits = heroName;
						villainHP -= heroHit;
						firstHit = heroName;
						Console.WriteLine("hero hit number {0}", heroHit);
					} else if (villainNum > heroNum)
					{
						whoHits = villainName;
						heroHP -= villainHit;
						firstHit = villainName;
						Console.WriteLine("villain hit number {0}", villainHit);
					}
					Console.WriteLine(whoHits);
					

				} else if (gameRound > 1)
				{
					if (firstHit == heroName)
					{
						heroHit = rnd.Next(6, 9);
						criticalHit = rnd.Next(1, 101);
						missHit = rnd.Next(1, 101);
						
						//Critical chance 
						if (criticalHit <= 99)
						{
							heroHit *= heroHit;
							critical = true;
							Console.WriteLine("critical hit {0}", criticalHit);
							Console.WriteLine("hero critical {0}", critical);
							Console.WriteLine("hero critical", critical);
						}
						else
						{
							heroHit = heroHit;
							critical = false;
							Console.WriteLine("critical hit {0}",criticalHit);
							Console.WriteLine("hero critical {0}", critical);
						}

						//miss chance
						if (missHit <= 20)
						{
							heroHit = 0;
							miss = true;
							Console.WriteLine("miss hit {0}", missHit);
							Console.WriteLine("hero miss {0}", miss);
						}
						else
						{
							heroHit = heroHit;
							miss = false;
							Console.WriteLine("missHit {0}",missHit);
							Console.WriteLine("hero miss {0}", miss);
						}

					}
					Console.WriteLine("hero hp {0}", heroHP);
					Console.WriteLine("villain hp {0}", villainHP);
					
				}
				




				gameRound++;
			}
		}
	}
}
