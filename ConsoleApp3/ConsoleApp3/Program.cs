using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

	class MyBaseClass : object
	{
		public MyBaseClass() // :base()가 생략된 것이다.
		{
			/////////////////////////////////// <- 생성자의 첫번째 라인에서 object가서 생성자 실행함
			Console.WriteLine(">>> MyBaseClass()");
		}

		public MyBaseClass(int i) // :base()가 생략된 것이다.
		{
			Console.WriteLine(">>> MyBaseClass(int i)");
		}
	}

	class MyClass : MyBaseClass
	{
		public MyClass() // :base()가 생략된 것이다.
		{
			////////////////////////////////// <- 생성자의 첫번째라인에서 부모의 생성자
			Console.WriteLine(">>> MyClass()");
		}

		// 생성자가 실행되기 전에 먼저 base(i)를 실행하라는것, 먼저 태어날 곳을 지정해주는 것임
		// 부모의 파라미터 1개짜리 먼저 실행하라는것이다.
		public MyClass(int i) : base(i)
		{
			Console.WriteLine(">>> MyClass(int i)");
		}

		public MyClass(int i, int j) // : base() 생략됨
		{
			Console.WriteLine(">>> MyClass(int i, int j)");
		}

		public MyClass(int i, int j, int k) : base(i)
		{
			Console.WriteLine(">>> MyClass(int i, int j, int k)");
		}

		// 4개짜리 생성자 먼저 호출하기 전에 2개짜리 생성자 먼저 호출하라는 뜻
		public MyClass(int i, int j, int k, int l) : this(i, j)
		{
			Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass m1 = new MyClass(); // MyBaseClass(), MyClass()
			MyClass m2 = new MyClass(1); // MyBaseClass(int i), MyClass(int i)
			MyClass m3 = new MyClass(1, 2); // MyBaseClass(), MyClass(int i, int j)
			MyClass m4 = new MyClass(1, 2, 3); // MyBaseClass(int i), MyClass(int i, int j, int k)
			MyClass m5 = new MyClass(1, 2, 3, 4); // MyBaseClass(int i, int j), MyClass(int i, int j, int k, int l)
		}
	}
}
