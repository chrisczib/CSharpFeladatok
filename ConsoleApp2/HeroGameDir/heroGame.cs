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
			int gameRound = 0;
			string whoHits = "";
			bool critical = false;
			int criticalHit = 0;
			bool miss = false;
			int missHit = 0;
			string firstHit = "";
			bool game = true;
			string nextHit = "";

			


			while (game)
			{
				gameRound++;

				while (gameRound <= 10)
				{
					gameRound++;
					heroHP -= rnd.Next(6, 9);
					villainHP -= rnd.Next(5, 8);

					Console.WriteLine("gameround = {0}", gameRound);

					if (gameRound == 10 && heroHP >= 1 && villainHP >= 1)
					{
						Console.WriteLine("$$$$$$$  DÖNTETLEN  $$$$$$$");
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						Console.WriteLine("Még egy játék?");
						string oneMore = Console.ReadLine();
						if (oneMore == "igen")
						{
							gameRound = 0;
							heroHP = 60;
							villainHP = 70;
							whoHits = "";
							firstHit = "";
							game = true;
						}
						else
						{
							game = false;
						}

					}
					else if (gameRound < 10 && heroHP < 1)
					{
						Console.WriteLine("villain nyer");
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						Console.WriteLine("Még egy játék?");
						string oneMore = Console.ReadLine();
						if (oneMore == "igen")
						{
							gameRound = 0;
							heroHP = 60;
							villainHP = 70;
							whoHits = "";
							firstHit = "";
							game = true;
						}
						else
						{
							game = false;
						}
					}
					else if (gameRound < 10 && villainHP < 1)
					{
						Console.WriteLine("hero nyer");
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						Console.WriteLine("Még egy játék?");
						string oneMore = Console.ReadLine();
						if (oneMore == "igen")
						{
							gameRound = 0;
							heroHP = 60;
							villainHP = 70;
							whoHits = "";
							firstHit = "";
							game = true;
						}
						else
						{
							game = false;
						}
					}


				}


				/*
				
				if (gameRound == 10)
				{
					//&& heroHP >= 1 && villainHP >= 1
					
				} 



				*/




















				/*
				while (gameRound < 10 + 1)
				{
					if (gameRound == 10 && villainHP >= 1 && heroHP >= 1)
					{
						Console.WriteLine("Döntetlen");
						Console.WriteLine("még egy játék?");
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						string play = Console.ReadLine();
						if (play == "igen")
						{
							game = true;
						}
						else if (play == "nem")
						{
							game = false;
						}
						else
						{
							game = false;
						}
					}
					else if (heroHP > 0 && villainHP == 0)
					{
						Console.WriteLine("A nyertes: {0}", heroName);
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						Console.WriteLine("még egy játék?");
						string play = Console.ReadLine();
						if (play == "igen")
						{
							game = true;
						}
						else if (play == "nem")
						{
							game = false;
						}
						else
						{
							game = false;
						}
					}
					else if (villainHP > 0 && heroHP == 0)
					{
						Console.WriteLine("A nyertes: {0}", villainName);
						Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
						Console.WriteLine("még egy játék?");
						string play = Console.ReadLine();
						if (play == "igen")
						{
							game = true;
							gameRound = 1;
							heroHP = 60;
							villainHP = 70;
						}
						else if (play == "nem")
						{
							game = false;
							gameRound = 11;
							heroHP = 60;
							villainHP = 70;
						}
						else
						{
							game = false;
							gameRound = 11;
							heroHP = 60;
							villainHP = 70;
						}
					}
					//first hit calculator
					if (gameRound == 1)
					{
						Console.WriteLine("");
						Console.WriteLine("[IIIII Round: {0} IIIII]", gameRound);
						heroNum += rnd.Next(1, 101);
						villainNum += rnd.Next(1, 101);
						Console.WriteLine("hero number: {0}", heroNum);
						Console.WriteLine("villain number: {0}", villainNum);
						if (heroNum > villainNum)
						{
							firstHit = heroName;
							whoHits = heroName;
							heroHit = rnd.Next(6, 9);
							criticalHit = rnd.Next(1, 101);
							missHit = rnd.Next(1, 101);

							//Critical chance 
							if (criticalHit <= 30)
							{
								heroHit = heroHit * 2;
								villainHP -= heroHit;
								Console.WriteLine("hero hit value: {0}", heroHit);
								critical = true;
								Console.WriteLine("hero critical hit {0}", criticalHit);
								Console.WriteLine("hero critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								heroHit = heroHit;
								villainHP -= heroHit;
								critical = false;
								Console.WriteLine("hero critical hit {0}", criticalHit);
								Console.WriteLine("hero critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}

							//miss chance
							if (missHit <= 20)
							{
								heroHit = 0;
								villainHP -= heroHit;
								miss = true;
								Console.WriteLine("hero miss hit {0}, hero miss {1}", missHit, miss);
								Console.WriteLine("hero miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								heroHit = heroHit;
								villainHP -= heroHit;
								miss = false;
								Console.WriteLine("hero missHit {0}", missHit);
								Console.WriteLine("hero miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							whoHits = villainName;
						}
						else if (villainNum > heroNum)
						{
							firstHit = villainName;
							whoHits = villainName;
							villainHit = rnd.Next(5, 8);
							criticalHit = rnd.Next(1, 101);
							missHit = rnd.Next(1, 101);

							//Critical chance 
							if (criticalHit <= 30)
							{
								villainHit = villainHit * 2;
								heroHP -= villainHit;
								Console.WriteLine("Villain hit number: {0}", villainHit);
								critical = true;
								Console.WriteLine("villain critical hit {0}", criticalHit);
								Console.WriteLine("villain critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								villainHit = villainHit;
								heroHP -= villainHit;
								critical = false;
								Console.WriteLine("villain critical hit {0}", criticalHit);
								Console.WriteLine("villain critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							//miss chance
							if (missHit <= 20)
							{
								villainHit = 0;
								heroHP -= villainHit;
								miss = true;
								Console.WriteLine("villain miss hit {0}", missHit);
								Console.WriteLine("villain miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								villainHit = villainHit;
								heroHP -= villainHit;
								miss = false;
								Console.WriteLine("villain missHit {0}", missHit);
								Console.WriteLine("villain miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							whoHits = heroName;
						}
						Console.WriteLine("first hit is: {0}", whoHits);
						Console.WriteLine("");
						gameRound++;
					}
					else if (gameRound > 1 && gameRound < 11)
					{
						Console.WriteLine("[IIIII Round: {0} IIIII]", gameRound);
						Console.WriteLine("");
						if (whoHits == heroName)
						{
							Console.WriteLine("whohits = hero");
							heroHit = rnd.Next(6, 9);
							criticalHit = rnd.Next(1, 101);
							missHit = rnd.Next(1, 101);

							//Critical chance 
							if (criticalHit <= 30)
							{
								heroHit = heroHit * 2;
								villainHP -= heroHit;
								Console.WriteLine("hero hit value: {0}", heroHit);
								critical = true;
								Console.WriteLine("hero critical hit {0}", criticalHit);
								Console.WriteLine("hero critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								heroHit = heroHit;
								villainHP -= heroHit;
								critical = false;
								Console.WriteLine("hero critical hit {0}", criticalHit);
								Console.WriteLine("hero critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}

							//miss chance
							if (missHit <= 20)
							{
								heroHit = 0;
								villainHP -= heroHit;
								miss = true;
								Console.WriteLine("hero miss hit {0}, hero miss {1}", missHit, miss);
								Console.WriteLine("hero miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								heroHit = heroHit;
								villainHP -= heroHit;
								miss = false;
								Console.WriteLine("hero missHit {0}", missHit);
								Console.WriteLine("hero miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							
							whoHits = villainName;
						}
						else if (whoHits == villainName)
						{
							Console.WriteLine("whohits = villain");
							villainHit = rnd.Next(5, 8);
							criticalHit = rnd.Next(1, 101);
							missHit = rnd.Next(1, 101);

							//Critical chance 
							if (criticalHit <= 30)
							{
								villainHit = villainHit * 2;
								heroHP -= villainHit;
								Console.WriteLine("Villain hit number: {0}", villainHit);
								critical = true;
								Console.WriteLine("villain critical hit {0}", criticalHit);
								Console.WriteLine("villain critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								villainHit = villainHit;
								heroHP -= villainHit;
								critical = false;
								Console.WriteLine("villain critical hit {0}", criticalHit);
								Console.WriteLine("villain critical {0}", critical);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							//miss chance
							if (missHit <= 20)
							{
								villainHit = 0;
								heroHP -= villainHit;
								miss = true;
								Console.WriteLine("villain miss hit {0}", missHit);
								Console.WriteLine("villain miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							else
							{
								villainHit = villainHit;
								heroHP -= villainHit;
								miss = false;
								Console.WriteLine("villain missHit {0}", missHit);
								Console.WriteLine("villain miss {0}", miss);
								Console.WriteLine("villain hp: {0}, hero hp: {1}", villainHP, heroHP);
							}
							whoHits = heroName;
						}
						gameRound++;
					}

					
					if (heroHP <= 0)
					{
						heroHP = 0;
					}
					if (villainHP <= 0)
					{
						villainHP = 0;
					}

					
				}

				


			*/
			}
		}
	}
}
