using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeTest
{
	// Garbage라는 클래스에 IDisposable을 구현
	class Garbage : IDisposable
	{
		private bool isDispose = false;
		private string name;

		public Garbage(string name)
		{
			this.name = name;
			Console.WriteLine("{0}객체 생성됨..", this.name);
		}
		~Garbage() // Finalize 메소드로 변환됨
		{
			// 혹시나 모르니까 다시한번 호출해주는 것
			if (!isDispose)
			{
				Dispose();
			}
		}

		public void Dispose()
		{
			isDispose = true;
			//.. 리소스를 해제하는 코드를 삽입
			Console.WriteLine("{0}객체의 리소스 해제 OK..", name);
			GC.SuppressFinalize(this);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Garbage g1 = new Garbage("1번객체");
			Garbage g2 = new Garbage("2번객체");
			Garbage g3 = new Garbage("3번객체");
			Garbage g4 = new Garbage("4번객체");

			g1.Dispose();
			GC.SuppressFinalize(g2);
		}
	}
}
