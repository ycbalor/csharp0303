using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		//// 리스트
		//static void Main(string[] args)
		//{
		//	ArrayList onj = new ArrayList();
		//	// List<string> onj = new List<string>();

		//	onj.Add("Onj");
		//	onj.Add("OracleJava");
		//	onj.Add("Community");

		//	Console.WriteLine("onj List");
		//	Console.WriteLine("Count : {0}", onj.Count);
		//	Console.WriteLine("Capacity : {0}", onj.Capacity);
		//	PrintValues(onj);

		//	ArrayList onj2 = (ArrayList)onj.Clone();
		//	Console.WriteLine("onj2 Values");
		//	PrintValues(onj2);

		//}

		//public static void PrintValues(IEnumerable myList)
		//{
		//	foreach (Object obj in myList)
		//		Console.WriteLine("{0}", obj);
		//	Console.WriteLine();
		//}

		// 해시테이블
		static void Main(string[] args)
		{
			// Hashtable onj = new Hashtable();
			Dictionary<string, string> onj = new Dictionary<string, string>();

			onj.Add("김길동", "서울");
			onj.Add("홍길동", "광주");
			onj.Add("박길동", "부산");

			try
			{
				onj.Add("김길동", "서울");
			}
			catch
			{
				Console.WriteLine("키값 중복..");
			}

			Console.WriteLine("For Key = \"name\":{0}", onj["홍길동"]);
			onj["박길동"] = "제주";
			Console.WriteLine("For Key = \"name\":{0}", onj["박길동"]);

			if (!onj.ContainsKey("최길동"))
			{
				onj.Add("최길동", "하와이");
				Console.WriteLine("Value added for key = \"who\":{0}", onj["박길동"]);
			}
			Console.WriteLine();

			// foreach (DictionaryEntry d in onj)
			foreach(KeyValuePair<string, string> d in onj)
			{
				Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
			}

			SortedList s = new SortedList(onj); // 해시 테이블을 정렬하기 위해 Sorted 리스트에 넣는다.

			foreach (DictionaryEntry d in s)
			{
				Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
			}
		}
	}
}
