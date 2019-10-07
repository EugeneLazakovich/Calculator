using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Number
    {
        public void GetNum(string num, Label label2)
        {
            string temp = label2.Text;
            if (temp != String.Empty)
            {
                try
                {
                    if (temp[0] == '0')
                    {
                        if (temp[1] == ',')
                        {
                            label2.Text += num;
                        }
                    }
                    else if (temp[0] == '-')
                    {
                        temp = temp.Substring(1);
                        if (temp != String.Empty)
                        {
                            if (temp[0] == '0')
                            {
                                if (temp[1] == ',')
                                {
                                    label2.Text += num;
                                }
                            }
                            else
                            {
                                label2.Text += num;
                            }
                        }
                        else
                        {
                            label2.Text += num;
                        }
                    }
                    else
                    {
                        label2.Text += num;
                    }
                }
                catch { }
            }
            else
            {
                label2.Text += num;
            }
        }
        public void GetComma(Label label2)
        {
            if (label2.Text != String.Empty && label2.Text != "-")
            {
                Boolean flag = true;
                for (int i = 0; i < label2.Text.Length; i++)
                {
                    if (label2.Text[i] == ',')
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    label2.Text += ",";
                }
            }
            else
            {
                label2.Text += "0,";
            }
        }
    }
}
