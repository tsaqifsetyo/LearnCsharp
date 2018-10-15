using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("") && (textBox1.Text == ("")))
                {
                MessageBox.Show("WRONG USERNAME OR PASSWORD EMPTY!");
            }
            else if (textBox1.Text == ("admin") && (textBox2.Text == ("qif")))
            {
                MessageBox.Show("CONGRATULATIONS LOGIN SUCCESFULLY");
                this.Hide();
                Main qq = new Main();
                qq.Show();
            }
            else if(textBox1.Text != ("admin") && (textBox2.Text == ("qif")))
            {
                MessageBox.Show("WRONG THE USERNAME OR PASSWORD!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
