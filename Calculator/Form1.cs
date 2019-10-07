using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        readonly Action action = new Action();
        readonly Number number = new Number();
        int temp = 0;
        string tempText;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    number.GetNum("0", label2);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    number.GetNum("1", label2);                 
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    number.GetNum("2", label2);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    number.GetNum("3", label2);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    number.GetNum("4", label2);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    number.GetNum("5", label2);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    number.GetNum("6", label2);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    number.GetNum("7", label2);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    number.GetNum("8", label2);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    number.GetNum("9", label2);
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                    number.GetComma(label2);
                    break;
                case Keys.Add:
                case Keys.Oemplus:                
                    Button1_Click(sender, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    Button2_Click(sender, e);
                    break;
                case Keys.Multiply:
                    Button3_Click(sender, e);
                    break;
                case Keys.Divide:
                    Button4_Click(sender, e);
                    break;
                case Keys.Enter:               
                    Button5_Click(sender, e);
                    break;
                case Keys.Back:
                    action.Backspace(label2);
                    break;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            temp = 1;
            if (label2.Text != String.Empty)
            {
                tempText = label2.Text;
                label2.Text = null;
            }                        
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if(label2.Text != String.Empty)
            {
                temp = 2;
                tempText = label2.Text;
                label2.Text = null;
            }
            else
            {
                label2.Text += "-";
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            temp = 3;
            if (label2.Text != String.Empty)
            {
                tempText = label2.Text;
                label2.Text = null;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            temp = 4;
            if (label2.Text != String.Empty)
            {
                tempText = label2.Text;
                label2.Text = null;
            }
        }  
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                switch (temp)
                {
                    case 1:
                        label1.Text = Convert.ToString(action.Sum(Convert.ToDouble(tempText),
                            Convert.ToDouble(label2.Text)));
                        break;
                    case 2:
                        label1.Text = Convert.ToString(action.Subtract(Convert.ToDouble(tempText),
                            Convert.ToDouble(label2.Text)));
                        break;
                    case 3:
                        label1.Text = Convert.ToString(action.Multiply(Convert.ToDouble(tempText),
                            Convert.ToDouble(label2.Text)));
                        break;
                    case 4:
                        label1.Text = Convert.ToString(action.Divide(Convert.ToDouble(tempText),
                            Convert.ToDouble(label2.Text)));
                        break;
                }
                label2.Text = null;
            }
            catch
            {
                label1.Text = "Please enter valid values";                
            }            
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            number.GetNum("0", label2);           
        }        
        private void Button7_Click(object sender, EventArgs e)
        {
            number.GetNum("1", label2);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            number.GetNum("2", label2);
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            number.GetNum("3", label2);
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            number.GetNum("4", label2);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            number.GetNum("5", label2);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            number.GetNum("6", label2);
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            number.GetNum("7", label2);
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            number.GetNum("8", label2);
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            number.GetNum("9", label2);
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            number.GetComma(label2);
        }
    }
}
