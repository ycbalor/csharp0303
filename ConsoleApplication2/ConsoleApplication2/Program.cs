using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	public class Dog
	{
		public string name { get; set; }
		public void Jitda()
		{
			Console.WriteLine(name + "가 짖다.");
		}

	}

	public class Pudle : Dog
	{
		public void Work() { Console.WriteLine(name + "가 일한다."); }
	}

	public class Jindo : Dog
	{
		public void Work() { Console.WriteLine(name + "가 일한다."); }
	}

	class Program
	{
		static void Main(string[] args)
		{
			Pudle pudle = new Pudle();
			pudle.name = "곰둥이";
			pudle.Jitda();
			pudle.Work();

			Jindo jindo = new Jindo();
			jindo.name = "김용찬";
			jindo.Jitda();
			jindo.Work();
		}
	}
}
