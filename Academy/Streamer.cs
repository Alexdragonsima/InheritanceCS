using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	//Single responsibility principle
	internal class Streamer
	{
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		internal static string SetDirectory()
		{
			string location = System.Reflection.Assembly.GetEntryAssembly().Location;
			string path = System.IO.Path.GetDirectoryName(location);
			Console.WriteLine(location);
            Console.WriteLine(path);
			Directory.SetCurrentDirectory($"{path}\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine("\n--------------------------------------\n");
			return Directory.GetCurrentDirectory();
		}
		internal static void Save(Human[] group, string filename)
		{
			SetDirectory();
			Console.WriteLine("Sep=,");
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToFileString());
			}
			sw.Close();
			Process.Start("excel", filename);
		}
		//CSV-Comma Separated Values
		internal static Human[] Load(string filename)
		{
			SetDirectory();
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] values = buffer.Split(';');
					values = values.Where(s => s != "").ToArray();
					if (values.Length == 1) continue;
                    Console.WriteLine(buffer);
					//Human human = HumanFactory.Create(values[0]);
					//human.Init(values);
					//group.Add(human);
					group.Add(HumanFactory.Create(values[0]).Init(values));
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();
		}
	}
}
