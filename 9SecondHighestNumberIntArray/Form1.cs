using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9SecondHighestNumberIntArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            FindSecondHighestInt x = new FindSecondHighestInt(textBox1.Text.Split(','));
            result = x.findIt();
            label2.Text = result;
        }
    }
}
