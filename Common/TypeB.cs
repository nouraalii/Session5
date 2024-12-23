using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        private int X;
        internal int Y;
        public int Z;
        void func01()
        {
            TypeA typeA = new TypeA();
            TypeB typeB = new TypeB();

            typeB.X = 12;
            typeB.Y = 12;
            typeB.Z = 12;

        }
    }
}
