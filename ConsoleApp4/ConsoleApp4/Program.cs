using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	// 값 전달, 참조 전달
	class OnjOutTest
	{
		// 초기화 안된 배열을 받아서 초기화
		// out 매개변수의 경우 초기화시킨 배열을 넘길 수도 있다.
		static void FillArray1(out int[] arr)
		{
			arr = new int[3] { 5919, 4790, 4791 };
		}

		// 초기화 된 배열을 받아서 값 변경
		static void FillArray2(ref int[] arr)
		{
			if (arr == null)
			{
				arr = new int[3];
			}
			arr[0] = 1111;
			arr[1] = 2222;
		}

		static void Main()
		{
			int[] onjArray;
			FillArray1(out onjArray);

			// 배열 출력
			Console.WriteLine("배열(out parameter):");

			for (int i = 0; i < onjArray.Length; i++)
			{
				Console.WriteLine(onjArray[i] + " ");
			}

			FillArray2(ref onjArray);

			//배열 출력
			Console.WriteLine("배열(ref parameter):");
			for (int i = 0; i < onjArray.Length; i++)
			{
				Console.WriteLine(onjArray[i] + " ");
			}

			// FillArray2(ref onjArray);

		}
	}
}
