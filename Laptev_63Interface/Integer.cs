using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptev_63Interface
{
    internal class Integer : INumber
    {
        public double I1 { get; set; }
        public double I2 { get; set; }
        public string Operation1 { get; set; }
        public Integer(double i1, double i2)
        {
            I1 = i1;
            I2 = i2;
        }

        public double Div()
        {
            return I1 / I2;
        }

        public double Mult()
        {
            return I1 * I2;
        }
        public double Sub()
        {
            return I1 - I2;
        }
        public double Sum()
        {
            return I1 + I2;
        }
        public string Print()
        {
            return $"Summa = {Sum()} " + $"Raznost = {Sub()}\n" + $"Proizvedenie = {Mult()} " + $"Delenie = {Div()}";
        }
    }
}
