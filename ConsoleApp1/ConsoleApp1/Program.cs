using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	// 추상 클래스는 상속을 위한 것 (단일 상속)
	// 인터페이스는 구현하는 것 (인터페이스는 다중 상속이 가능함)

	interface Dog // 안에 올 수 있는 것 : 메소드, 속성, 이벤트, 인덱서, 필드(멤버필드 말고)
	{
		// 안써도 public임 왜냐하면 수평적인 개념이기 때문에 아무나 와서 구현하면 된다는 개념
		string name { get; set; } // 속성
		void Jitda(); // 추상 메소드 (인터페이스 안에는 구현된 메소드가 못들어감 그러므로 자동으로 abstract 메소드가 됨)
		// 추상클래스에는 구현된 메소드와 안구현된게 들어갈 수 있지만 인터페이스는 불가능
	}

	class Pudle : Dog
	{
		public string name { get; set; }

		public void Work()
		{
			Console.WriteLine(name + "일한다.");
		}
		public void Jitda()
		{
			Console.WriteLine(name + "짖는다.");
		}
	}

	class Jindo : Dog
	{
		public string name { get; set; }

		public void Run()
		{
			Console.WriteLine(name + "달린다.");
		}
		public void Jitda()
		{
			Console.WriteLine(name + "짖는다.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Dog pudle = new Pudle();
			pudle.name = "푸들이";
			pudle.Jitda();
			((Pudle)pudle).Work();

			Dog jindo = new Jindo();
			jindo.name = "진돌이";
			jindo.Jitda();
			((Jindo)jindo).Run();
		}
	}
}
