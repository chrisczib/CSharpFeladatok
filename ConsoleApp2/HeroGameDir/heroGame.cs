using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.HeroGameDir;

namespace ConsoleApp2.HeroGameDir
{
	class heroGame
	{
		static throwaway _missChance = new throwaway();
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
						firstHit = heroName;
						Console.WriteLine("hero attack damage {0}", heroHit);
					} else if (villainNum > heroNum)
					{
						whoHits = villainName;
						firstHit = villainName;
						Console.WriteLine("villain hit number {0}", villainHit);
					}
					Console.WriteLine("first hit is: {0}",whoHits);
					

				} else if (gameRound > 1)
				{
					if (firstHit == heroName)
					{
						heroHit = rnd.Next(6, 9);
						criticalHit = rnd.Next(1, 101);
						missHit = rnd.Next(1, 101);
						
						//Critical chance 
						if (criticalHit <= 30)
						{
							heroHit = heroHit * 2;
							villainHP -= heroHit;
							Console.WriteLine("hero hit value: {0}",heroHit);
							critical = true;
							Console.WriteLine("hero critical hit {0}", criticalHit);
							Console.WriteLine("hero critical {0}", critical);
						}
						else
						{
							heroHit = heroHit;
							villainHP -= heroHit;
							critical = false;
							Console.WriteLine("hero critical hit {0}",criticalHit);
							Console.WriteLine("hero critical {0}", critical);
						}

						//miss chance
						_missChance.missChance();

						if (missHit <= 20)
						{
							heroHit = 0;
							villainHP -= heroHit;
							miss = true;
							Console.WriteLine("hero miss hit {0}", missHit);
							Console.WriteLine("hero miss {0}", miss);
						}
						else
						{
							heroHit = heroHit;
							villainHP -= heroHit;
							miss = false;
							Console.WriteLine("hero missHit {0}",missHit);
							Console.WriteLine("hero miss {0}", miss);
						}

					}
					else if (firstHit == villainName)
					{
						villainHit = rnd.Next(5, 8);
						criticalHit = rnd.Next(1, 101);
						missHit = rnd.Next(1, 101);

						//Critical chance 
						if (criticalHit <= 30)
						{
							villainHit = villainHit * 2;
							heroHP -= villainHit;
							Console.WriteLine("Villain hit number: {0}",villainHit);
							critical = true;
							Console.WriteLine("villain critical hit {0}", criticalHit);
							Console.WriteLine("villain critical {0}", critical);
						}
						else
						{
							villainHit = villainHit;
							heroHP -= villainHit;
							critical = false;
							Console.WriteLine("villain critical hit {0}", criticalHit);
							Console.WriteLine("villain critical {0}", critical);
						}

						//miss chance
						if (missHit <= 20)
						{
							villainHit = 0;
							heroHP -= villainHit;
							miss = true;
							Console.WriteLine("villain miss hit {0}", missHit);
							Console.WriteLine("villain miss {0}", miss);
						}
						else
						{
							villainHit = villainHit;
							heroHP -= villainHit;
							miss = false;
							Console.WriteLine("villain missHit {0}", missHit);
							Console.WriteLine("villain miss {0}", miss);
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
