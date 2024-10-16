//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);
			Console.WriteLine("------------------------------------------------------------");

			Student student = new Student("Pincman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);
			Console.WriteLine("------------------------------------------------------------");

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher);
			Console.WriteLine("------------------------------------------------------------");

			Graduate graduate = new Graduate("Schrider", "Hank", 40, "Criminalistic", "OBN", 50, 70, "How to catch Heisenberg");
			graduate.Print();
			Console.WriteLine(graduate);
			Console.WriteLine("------------------------------------------------------------");
#endif

			Human[] group = new Human[]
				{
					new Student ("Pincman", "Jessie", 22, "Chemistry",     "WW_220", 95,  96),
					new Teacher ("White",   "Walter", 50, "Chemistry",                    25),
					new Graduate("Schreder","Hank",   40, "Criminalistic", "DEA",    70,  40, "How to catch Heisenberg"),
					new Student ("Vercetti","Tommy",  30, "Thieft",        "Vice",   95,  98),
					new Teacher ("Diaz",    "Ricardo",50, "Weapons distribution",         20)
				};
			Streamer.Print(group);
			Streamer.Save(group, "group.txt");
			//StreamWriter sw = new StreamWriter("File.txt");
			//sw.WriteLine("Hello Files");
			//sw.Close();
			//StreamWriter sw = File.AppendText("File.txt");
			//sw.WriteLine();
			//sw.Close();
			//Process.Start("notepad", "File.txt");
		}
	}
}
