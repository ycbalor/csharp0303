﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
	//class Stack1
	//{
	//	int top = 0;
	//	int[] ar = new int[10];

	//	public void Push(int obj)
	//	{
	//		ar[top] = obj;
	//		top++;
	//	}

	//	public int Pop()
	//	{
	//		top--;
	//		return ar[top];
	//	}
	//}

	//class Stack2
	//{
	//	int top = 0;
	//	string[] ar = new string[10];

	//	public void Push(string obj)
	//	{
	//		ar[top] = obj;
	//		top++;
	//	}

	//	public string Pop()
	//	{
	//		top--;
	//		return ar[top];
	//	}
	//}

	class Stack3<T>
	{
		int top = 0;
		T[] ar = new T[10];

		public void Push(T obj)
		{
			ar[top] = obj;
			top++;
		}

		public T Pop()
		{
			top--;
			return ar[top];
		}
	}


	class StackTest
	{
		static void Main()
		{
			Stack3<int> s3 = new Stack3<int>();

			s3.Push(1);
			s3.Push(2);
			s3.Push(3);
			Console.WriteLine(s3.Pop());
			Console.WriteLine(s3.Pop());
			Console.WriteLine(s3.Pop());

			Stack3<string> s4 = new Stack3<string>();
			s4.Push("KOREA");
			s4.Push("대한민국");
			s4.Push("서울");

			Console.WriteLine(s4.Pop());
			Console.WriteLine(s4.Pop());
			Console.WriteLine(s4.Pop());

			//Stack1 s1 = new Stack1();

			//s1.Push(1);
			//s1.Push(2);
			//s1.Push(3);
			//Console.WriteLine(s1.Pop());
			//Console.WriteLine(s1.Pop());
			//Console.WriteLine(s1.Pop());

			//Stack2 s2 = new Stack2();

			//s2.Push("KOREA");
			//s2.Push("대한민국");
			//s2.Push("서울");

			//Console.WriteLine(s2.Pop());
			//Console.WriteLine(s2.Pop());
			//Console.WriteLine(s2.Pop());
		}
	}
}