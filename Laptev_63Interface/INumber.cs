using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptev_63Interface
{
    internal interface INumber
    {
        public abstract double Sum();
        public abstract double Sub();
        public abstract double Mult();
        public abstract double Div();
        public abstract string Print();

    }
}
