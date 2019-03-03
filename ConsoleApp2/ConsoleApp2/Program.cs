using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 오버라이드 기본 공식 (부모는 virtual 자식은 override이고 override된건 다른 곳에서 또 override 할 수 있음)
namespace ConsoleApp2
{
	// 부모
	public class Dog
	{
		public string Name { get; set; }

		// virtual는 가짜같은 느낌 가짜니까 다른곳에서 자식들이 재정의 할 수 있다. 이런뜻.
		public virtual void Jitda()
		{
			Console.WriteLine(Name + "가 짖다.");
		}
	}

	// 푸들이 부모 상속받아서
	public class Pudle : Dog
	{
		// 짖다 메소드를 재정의
		public override void Jitda()
		{
			Console.WriteLine(Name + "푸들푸들~");
		}

		public void Work()
		{
			Console.WriteLine(Name + "가 일한다.");
		}
	}

	public class Jindo : Dog
	{
		// 짖다 메소드를 재정의
		public override void Jitda()
		{
			Console.WriteLine(Name + "곰둥곰둥~");
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
			pudle.Name = "푸들이";
			pudle.Jitda(); // 자식이 재정의를 했으면 자식의 Jitda 호출 안했으면 부모꺼 호출
			((Pudle)pudle).Work();

			Dog gomdung = new Jindo();
			gomdung.Name = "곰둥이";
			gomdung.Jitda();
			((Jindo)gomdung).Run();
		}
	}
}
