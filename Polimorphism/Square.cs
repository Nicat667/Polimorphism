using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    public class Square : Figure
    {
		private int _side;
		public int side
        {
			get { return _side; }
			set 
			{ 
				if (value > 0)
				{
                    _side = value;
                }
			}
		}
		public Square(int x)
		{
			side = x;
		}
		
		public override int CalcArea() 
		{
			return (side * side);
		}
	}
}
