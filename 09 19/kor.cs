using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19
{
	class kor
	{
		 double sugar;
		 double atmero;

		public double Sugar { get => sugar; set => sugar = value; }
		public double Atmero { get => atmero; set => atmero = value; }

		public double getKerulet ()
		{
			return 2 * sugar * Math.PI;
		}

		public double getTerulet()
		{
			return sugar * sugar * Math.PI;
		}

		public kor(double sugar)
		{
			this.sugar = sugar;
		}
	}
}
