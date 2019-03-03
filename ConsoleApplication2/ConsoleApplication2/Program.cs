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
		// public void Work() { Console.WriteLine(name + "가 일한다."); }

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
			// 업캐스팅
			Dog pudle = new Pudle();
			// Pudle pudle = new Pudle();
			((Pudle)pudle).name = "곰둥이";
			((Pudle)pudle).Jitda();
			((Pudle)pudle).Work();

			Dog jindo = new Jindo();
			((Pudle)jindo).name = "김용찬";
			((Pudle)jindo).Jitda();
			((Pudle)jindo).Work();
		}
	}
}
