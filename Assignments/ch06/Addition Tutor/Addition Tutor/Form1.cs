using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(Labelnum1.Text);
                int num2 = int.Parse(Labelnum2.Text);
                if (int.TryParse(ansTextbox.Text, out int ans))
                {
                    if (ans == num1 + num2)
                    {
                        MessageBox.Show("correct!");
                    }
                    else
                        MessageBox.Show("wrong!");
                }
                else
                    MessageBox.Show("Please enter a valid integer.");
            }

            catch
            {
                MessageBox.Show("Please click 'generate'.");
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            Random rnd = new Random();
            number1 = rnd.Next(100, 500);
            number2 = rnd.Next(100, 500);
            Labelnum1.Text = number1.ToString();
            Labelnum2.Text = number2.ToString();
            ansTextbox.Text = String.Empty;
        }
    }
}
