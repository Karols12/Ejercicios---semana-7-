using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4___s7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                double suma = numero1 + numero2;
                label3.Text = "La suma es de: " + suma.ToString();
            }

            else if (checkBox2.Checked == true)
            {
                double resta = numero1 - numero2;
                label3.Text = "La resta es de: " + resta.ToString();
            }

            else if (checkBox3.Checked == true)
            {
                double multiplicacion = numero1 * numero2;
                label3.Text = "La multiplicacion es de: " + multiplicacion.ToString();
            }

            else if (checkBox4.Checked == true)
            {
                double division = numero1 / numero2;
                label3.Text = "La division es de: " + division.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
