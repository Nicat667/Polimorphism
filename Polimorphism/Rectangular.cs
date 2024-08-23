using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Rectangular : Figure
    {
		private int _width;

		public int width
		{
			get { return _width; }
			set 
            {
                if (value > 0)
                {
                    _width = value;
                } 
            }
		}
        private int _length;

        public int length
        {
            get { return _length; }
            set 
            { 
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(int x, int y)
        {
            width = x;
            length = y;
        }
        
        public override int CalcArea() 
        {
            return width * length;
        }
    }
}
