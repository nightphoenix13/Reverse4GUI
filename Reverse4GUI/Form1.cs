// Written by Zack Rosales
// Program for page 349, # 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse4GUI
{
    public partial class Form1 : Form
    {
        string temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            temp = textBox1.Text;
            textBox1.Text = textBox4.Text;
            textBox4.Text = temp;
            temp = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = temp;
        }
    }
}
