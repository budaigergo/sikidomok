using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			kor kor = new kor(2.0);
			Console.WriteLine($"sugar:{ kor.Sugar},kerulet:{kor.getKerulet()}, terulet:{kor.getTerulet()}");
			Console.ReadLine();
			*/

			haromszog hsz = new haromszog(2,2,2);
			Console.WriteLine("kerulet:{0}",hsz.getKerulet());
			Console.WriteLine("terulet:{0}",hsz.getTerulet());
			
			Console.ReadLine();
		}
	}
}
