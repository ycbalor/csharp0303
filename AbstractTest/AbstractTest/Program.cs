using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
	// new에서 사용하려고 만드는게 아니라 다른 클래스에서 상속되어져서 틀로 만들려고 사용하는 클래스임. 
	// 일종의 규격을 만든다고 보면됨
	// 1. 개를 만들꺼면~
	public abstract class Dog
	{
		// 2. 이름을 만드세요.
		public string Name { get; set; }

		// 3.개 짖는것도 만드세요.
		public abstract void Jitda(); // 추상 메소드
		
		// 추상 메소드 하나라도 있으면 추상클래스가 되어야 한다.
	}

	public class Pudle : Dog
	{
		public override void Jitda()
		{
			Console.WriteLine(Name + "부들부들");
		}

		public void Work()
		{
			Console.WriteLine(Name + "가 일한다.");
		}
	}

	public class Jindo : Dog
	{
		public override void Jitda()
		{
			Console.WriteLine(Name + "진도진도"); 
		}

		public void Run()
		{
			Console.WriteLine(Name + "가 달린다.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Dog pudle = new Pudle();
			pudle.Name = "부들이";
			pudle.Jitda();
			((Pudle)pudle).Work();

			Dog jindo = new Jindo();
			jindo.Name = "진돌이";
			jindo.Jitda();
			((Jindo)jindo).Run();
		}
	}
}
