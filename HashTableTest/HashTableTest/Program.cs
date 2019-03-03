using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableTest
{
	class Program
	{
		static void Main(string[] args)
		{

			Dictionary<int, string> onj1 = new Dictionary<int, string>();
			Dictionary<int, string> onj2 = new Dictionary<int, string>();

			Goods ballpen = new Goods(1001, "볼펜", 1000);
			Goods pencil = new Goods(1002, "연필", 500);
			Goods straw = new Goods(1003, "딸기", 6000);

			//Console.WriteLine(ballpen.ToString());
			//Console.WriteLine(pencil.ToString());
			//Console.WriteLine(straw.ToString());

			Cart sumBallpen = new Cart(ballpen, 2);
			Cart sumPencil = new Cart(pencil, 3);
			Cart sumStraw = new Cart(straw, 2);

			//Console.WriteLine(sumBallpen.sum);
			//Console.WriteLine(sumPencil.sum);
			//Console.WriteLine(sumStraw.sum);

			onj1.Add(1001, ballpen.ToString());
			onj1.Add(1002, pencil.ToString());
			onj1.Add(1003, straw.ToString());

			onj2.Add(1001, sumBallpen.ToString());
			onj2.Add(1002, sumPencil.ToString());
			onj2.Add(1003, sumStraw.sum.ToString());


			foreach (KeyValuePair<int, string> d in onj1)
			{
				Console.WriteLine("{0} {1}", d.Key.ToString(), d.Value.ToString());
			}


			foreach (KeyValuePair<int, string> d in onj1)
			{
				Console.WriteLine("{0} {1}", d.Key.ToString(), d.Value.ToString());
			}

		}
	}

	class Goods
	{
		public int goodsno { get; set; } // 상품코드
		public string gname { get; set; } // 상품명
		public int danga { get; set; } // 단가
		public Goods(int goodsno, string gname, int danga)
		{
			this.goodsno = goodsno;
			this.gname = gname;
			this.danga = danga;
		}
		public string ToString()
		{
			return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가=" + danga + "]";
		}
	}

	class Cart
	{
		public Goods goods { get; set; } // 상품
		public int count { get; set; } // 수량
		public int sum // 합계금액
		{
			get { return count * goods.danga; }
			set { }
		}

		public Cart(Goods goods, int count)
		{
			this.goods = goods;
			this.count = count;
			sum = count * goods.danga;
		}

		public string ToString()
		{
			//return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum + "]";
			return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum + "]";
		}
	}
}



//using System;
//using System.Collections.Generic;

//class Goods
//{
//	public int goodsno { get; set; }
//	public string gname { get; set; }
//	public int danga { get; set; }

//	public Goods(int goodsno, string gname, int danga)
//	{
//		this.goodsno = goodsno;
//		this.gname = gname;
//		this.danga = danga;
//	}

//	public override String ToString()
//	{
//		return goodsno + " : " + gname + ":" + danga;
//	}
//}

//class Cart
//{
//	public Goods goods { get; set; }
//	public int count { get; set; }
//	public int sum { get { return goods.danga * count; } }

//	public Cart(Goods goods, int count)
//	{
//		this.goods = goods;
//		this.count = count;
//	}

//	public override String ToString()
//	{
//		return goods + " : " + count + " : " + sum;
//	}
//}

//class CartTest
//{
//	static void Main()
//	{
//		Goods g1 = new Goods(1001, "볼펜", 2000);
//		Goods g2 = new Goods(1002, "연필", 500);
//		Goods g3 = new Goods(1003, "딸기", 6000);

//		SortedList<int, Cart> carts = new SortedList<int, Cart>();
//		carts.Add(1, new Cart(g1, 2));
//		carts.Add(2, new Cart(g2, 3));
//		carts.Add(3, new Cart(g3, 2));

//		foreach (KeyValuePair<int, Cart> cart in carts)
//		{
//			Console.WriteLine(cart.Key + " : " + cart.Value);
//		}
//	}
//}