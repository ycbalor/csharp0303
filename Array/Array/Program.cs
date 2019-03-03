
using System;
using System.Collections.Generic;
namespace ConsoleApplication17
{

	class CreditCard
	{
		public string name;
	}

	class Customer
	{
		public int age;
		public CreditCard card; // 객체 안에 객체가 포함되어 있음

		public object ShallowCopy()
		{
			return this.MemberwiseClone();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Customer c1 = new Customer();
			c1.age = 20;
			c1.card = new CreditCard();
			c1.card.name = "비씨카드";

			Customer c2 = (Customer)c1.ShallowCopy();
			c2.card.name = "BC카드";

			Console.WriteLine("c1.card.name = " + c1.card.name);
			Console.WriteLine("c2.card.name = " + c2.card.name);
		}
	}
}