using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2.File_Handling
{
	class fileHandling
	{
		public void fileKezeles()
		{
			string fileName = @"C:\Users\czibe\source\repos\ConsoleApp2\ConsoleApp2\File Handling\csharp.txt";
			StreamWriter write = new StreamWriter(fileName, true, Encoding.Default);
			write.WriteLine("Ezt is szeretném beleírni a fileba");
			write.Close();
		}

		public void fileKezeles2()
		{
			StreamReader read = new StreamReader(@"C:\Users\czibe\source\repos\ConsoleApp2\ConsoleApp2\File Handling\csharp.txt", Encoding.Default);
			string text;
			//for (int i = 0; i < 3; i++)
			while (!read.EndOfStream)
			{
				text = read.ReadLine();
				Console.WriteLine(text);
			}
			read.Close();
			Console.ReadLine();
		
		}	

		public void fileKezeles3()
		{

		}

	}
}
