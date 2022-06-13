using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptev_63Interface
{
    internal class Real : INumber
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public Real(double r1,double r2)
        {
            R1 = r1;
            R2 = r2;
        }
        public double Div()
        {
            return R1 / R2;
        }

        public double Mult()
        {
            return R1 * R2;
        }
        public double Sub()
        {
            return R1 - R2;
        }

        public double Sum()
        {
            return R1 + R2;
        }
        public string Print()
        {
            return $"Summa = {Sum()} " + $"Raznost = {Sub()}\n" + $"Proizvedenie = {Mult()} " + $"Delenie = {Div()}";
        }
    }
}
