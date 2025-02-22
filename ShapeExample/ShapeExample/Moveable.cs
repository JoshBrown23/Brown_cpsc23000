using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample
{
    internal interface Moveable
    {
        public void Move(double dx, double dy);
        public void RandomMove(Random rnd);
    }
}
