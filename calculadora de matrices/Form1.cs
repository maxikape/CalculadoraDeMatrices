using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_matrices
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones objmatrices = new Operaciones();
        
        private void btnInsertarA_Click(object sender, EventArgs e)
        {
            objmatrices.insertarA(txtFilaA, txtColumnaA);

        }

        private void btnInsertarB_Click(object sender, EventArgs e)
        {
            objmatrices.insertarB(txtFilaB, txtComulnaB);

        }

        private void btnMostrarA_Click(object sender, EventArgs e)
        {
            objmatrices.MostrarA(dataGridView1);
        }

        private void btnMostrarB_Click(object sender, EventArgs e)
        {
            objmatrices.MostrarB(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objmatrices.Sumar(dataGridView3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            objmatrices.Restar(dataGridView3);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            objmatrices.Multiplicar(dataGridView3);
            

        }
 
    }
}
