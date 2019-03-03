using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
			// 배열도 객체라서 힙메모리 영역에 올라감
			// 힙 영역은 항상 0으로 초기화~

			// 선언 후 초기화
			//int[][] arr = new int[2][];
			//arr[0] = new int[5] { 1, 3, 5, 7, 9 };
			//arr[1] = new int[4] { 2, 4, 6, 8 };

			// 위와 동일 선언과 동시에 초기화
			int[][] arr =
			{
				new int[5] { 1, 3, 5, 7, 9 },
				new int[4] { 2, 4, 6, 8 }
			};

			for (int i = 0; i < arr.Length; i++) // arr의 길이 2
			{
				Console.Write("Element({0}):", i);
				for (int j = 0; j < arr[i].Length; j++) // arr[0]의 길이 5, arr[1]의 길드 4
				{
					Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
