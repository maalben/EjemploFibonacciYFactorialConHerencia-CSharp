using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploFibonacciConHerencia
{
    public partial class Form1 : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        Factorial factorial = new Factorial();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnverserie_Click(object sender, EventArgs e)
        {
            fibonacci.setNumero(long.Parse(txtnumero.Text));

            foreach (long valores in fibonacci.calcularFibonacci()) {
                ltb1.Items.Add(valores);
            }


            }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            ltb1.Items.Clear();
            lblfactorial.Visible = false;
        }

        private void btncalcularfactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumero(long.Parse(txtnumero.Text));
            lblfactorial.Visible = true;
            lblfactorial.Text = Convert.ToString(factorial.calcularFactorial());
        }
    }
    }

