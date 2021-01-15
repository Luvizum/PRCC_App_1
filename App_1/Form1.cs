using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] counters = new int[10];

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            char[] temp = text.ToCharArray();
            string[] tempN = new string[10];
            foreach (char item in temp)
            {
                if (Char.IsNumber(item))
                {
                    string next = "\r\n";
                    switch (item)
                    {
                        case '0': counters[0]++; tempN[0] = "0:" + counters[0].ToString() + next; break;
                        case '1': counters[1]++; tempN[1] = "1:" + counters[1].ToString() + next; break;
                        case '2': counters[2]++; tempN[2] = "2:" + counters[2].ToString() + next; break;
                        case '3': counters[3]++; tempN[3] = "3:" + counters[3].ToString() + next; break;
                        case '4': counters[4]++; tempN[4] = "4:" + counters[4].ToString() + next; break;
                        case '5': counters[5]++; tempN[5] = "5:" + counters[5].ToString() + next; break;
                        case '6': counters[6]++; tempN[6] = "6:" + counters[6].ToString() + next; break;
                        case '7': counters[7]++; tempN[7] = "7:" + counters[7].ToString() + next; break;
                        case '8': counters[8]++; tempN[8] = "8:" + counters[8].ToString() + next; break;
                        case '9': counters[9]++; tempN[9] = "9:" + counters[9].ToString() + next; break;
                    }
                }
            }
            foreach (string item in tempN)
            {
                textBox1.Text += item;
            }
        }
    }
}
