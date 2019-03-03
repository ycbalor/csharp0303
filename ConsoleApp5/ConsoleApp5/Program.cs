﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class CreditCard
	{
		public string name;
	}

	class Customer : ICloneable
	{
		public int age;
		public CreditCard card;

		public object Clone()
		{
			Customer c = new Customer();
			c.age = this.age;
			c.card = new CreditCard();
			c.card.name = this.card.name;
			return c;
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

			Customer c2 = (Customer)c1.Clone();
			c2.card.name = "BC카드";

			Console.WriteLine("c1.card.name = " + c1.card.name);
			Console.WriteLine("c1.card.name = " + c2.card.name);
		}
	}
}
