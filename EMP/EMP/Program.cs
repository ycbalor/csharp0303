using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{

	class Emp
	{
		public string Name { get; set; }
		internal Emp(string Name = "곰둥이")
		{
			this.Name = Name;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Emp emp = new Emp();
			Console.WriteLine(emp.Name);
			Emp emp2 = new Emp("곰덩이");
			Console.WriteLine(emp2.Name);
		}
	}
}
