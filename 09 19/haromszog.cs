using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19
{
	class haromszog
	{
		double a;
		double b;
		double c;
		public haromszog(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		public double A { get => a; set => a = value; }
		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }


		public double getKerulet()
		{
			return a + b + c;

		}

		public double getTerulet()
		{
			double p = (a + b + c) / 2;

			return Math.Sqrt(p*(p - a)*(p - b)*(p - c));

		}


	}

}
