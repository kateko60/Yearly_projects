using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatordemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            double Answer;
            int number1 = int.Parse(txtnumber1.Text);
            int number2 = int.Parse(txtnumber2.Text);

            if (rdbuttonadd.Checked)
            {

                Answer = number1 + number2;
                message += $"Answer is {Answer}";

                lblOutput.Text = message;
            }
            else
                if (rdbuttonsub.Checked)
            {
                Answer = number1 - number2;
                message += $"Answer is {Answer}";

                lblOutput.Text = message;
            }
             else
                if (rdbuttondivide.Checked)
            {
                if(number2 != 0)
                {
                    Answer = number1 / number2;
                    message += $"Answer is {Answer}";
                    lblOutput.Text = message;
                }
                else
                {
                    message += "Cannot divide by zero";
                    lblOutput.Text = message;
                }
            }

            else
                if (rdbuttonmultiply.Checked)
            {
                Answer = number1 * number2;
                message += $"Answer is {Answer}";

                lblOutput.Text = message;
            }

            else
            {
                message += "Please choose an option";
                lblOutput.Text = message;
            }
        }
    }
}
