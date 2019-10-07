using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Action
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public void Backspace(Label label2)
        {
            label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
        }
    }
}
