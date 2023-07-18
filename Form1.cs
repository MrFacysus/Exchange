using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateAmount();
        }

        private void UpdateAmount()
        {
            try
            {
                int[] bills = new int[] { 500, 200, 100, 50, 20, 10, 5, 1 };
                int[] returnbills = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
                int change = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                for (int i = 0; i < bills.Length; i++)
                {
                    int bill = bills[i];
                    int count = change / bill;
                    if (count > 0)
                    {
                        returnbills[i] = count;
                        change = change - count * bill;
                    }
                }
                richTextBox1.Text = "";
                for (int i = 0; i < bills.Length; i++)
                {
                    if (returnbills[i] > 0)
                    {
                        richTextBox1.Text += bills[i] + " kr:\t" + returnbills[i] + "x\n";
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateAmount();
        }
    }
}
