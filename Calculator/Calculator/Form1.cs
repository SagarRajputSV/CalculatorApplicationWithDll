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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = this.Text;
            CallClickEvent(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }

        protected void CallClickEvent(string BtnTxt)
        {
            TxtScreen.Text = BtnTxt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CallClickEvent(this.Text);
        }
    }
}
