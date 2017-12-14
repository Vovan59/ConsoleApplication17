using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {


            int n;


            if (!Int32.TryParse(textBox2.Text, out n))
                MessageBox.Show("!!!");

            else
            {

                n = Class1.Factorial(n);
                if (n == 0)
                    MessageBox.Show("!!!");
                else
                    label3.Text = Convert.ToString(n);
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
