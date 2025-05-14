using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_MJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.Items.Clear();
            lblresultado.Text = "";
            if (int.TryParse(txtnúmero.Text, out int número))
            {
                long factorial = 1;
                for (int i = número; i > 0; i--)
                {
                    factorial = factorial * i; //1*5=5,5*4=20,20*3=60,60*2=120,120*1=120
                }
            }
            else
            {
                MessageBox.Show("ingrese un número valido"); 
            }

           
        }
    }
}
