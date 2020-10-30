using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_matrices
{
    class Operaciones
    {
        //Form1 frm = new Form1();
        
        float[,] matrizA = new float[100, 100];
        float[,] matrizB = new float[100, 100];
        

        float[,] operacionresult = new float[100, 100];
        int i, j, fila1, columna1, fila2, columna2 ;

        public void insertarA(TextBox panel1, TextBox panel2)
        { 
            if (panel1.Text == "" || panel2.Text == "")
            {
                MessageBox.Show("ingrese datos");
            }

            else
            { 
                fila1 = int.Parse(panel1.Text);
                columna1 = int.Parse(panel2.Text);

                for (i=0; i < fila1; i++ )
                {
                    for (j=0; j < columna1; j++)
                    {
                        matrizA[i, j] = float.Parse(Interaction.InputBox("Datos i", "Datos en j", "", fila1, columna1));
                    }
                }
            }

        }
        
        public void insertarB(TextBox panel3, TextBox panel4)
        {
            if (panel3.Text == "" || panel4.Text == "")
            {
                MessageBox.Show("ingrese datos");
            }

            else
            {
                fila2 = int.Parse(panel3.Text);
                columna2 = int.Parse(panel4.Text);

                for (i = 0; i < fila2; i++)
                {
                    for (j = 0; j < columna2; j++)
                    {
                        matrizB[i, j] = float.Parse(Interaction.InputBox("Datos i", "Datos en j", "", fila2, columna2));
                    }
                }
            }

        }

        public void MostrarA(DataGridView tabla)
        { 
            tabla.RowCount = fila1;
            tabla.ColumnCount = columna1;
            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < columna1; j++)
                {
                    tabla.Rows[i].Cells[j].Value = matrizA[i, j].ToString();

                }

            }
        }


        public void MostrarB(DataGridView tabla)
        {
            tabla.RowCount = fila2;
            tabla.ColumnCount = columna2;
            for (int i = 0; i < fila2; i++)
            {
                for (int j = 0; j < columna2; j++)
                {
                    tabla.Rows[i].Cells[j].Value = matrizB[i, j].ToString();

                }

            }
        }


        public void Sumar(DataGridView suma)
        {
           if (fila1 == fila2 && columna1 == columna2)
           {

                    suma.RowCount = fila1;
                    suma.ColumnCount= columna2;
                 
                    for ( i = 0; i < fila1; i++)
                    {
                        for ( j = 0; j < columna2; j++)
                        {
                            operacionresult[i, j] = matrizA[i, j] + matrizB[i, j];
                            suma.Rows[i].Cells[j].Value = operacionresult[i, j].ToString();
                        }
                    }
           }
            else
            {
                MessageBox.Show("Las matricces A y B deben ser del mismo orden");
            }
        }

        public void Restar(DataGridView resta)
        {
            if (fila1 == fila2 && columna1 == columna2)
            {

                resta.RowCount = fila1;
                resta.ColumnCount = columna2;

                for (i = 0; i < fila1; i++)
                {
                    for (j = 0; j < columna2; j++)
                    {
                        operacionresult[i, j] = matrizA[i, j] - matrizB[i, j];
                        resta.Rows[i].Cells[j].Value = operacionresult[i, j].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Las matricces A y B deben ser del mismo orden");
            }
        }


        public void Multiplicar(DataGridView multiplica)
        {
            if (columna1 == fila2)
            {

                multiplica.RowCount = fila1;
                multiplica.ColumnCount = columna2;

                for (i = 0; i < fila1; i++)
                {
                    for (j = 0; j < columna2; j++)
                    {
                    operacionresult[i, j] = 0;
                        for (int z = 0; z < columna1; z++)
                        {
                            operacionresult[i, j]  = (matrizA[i, z] * matrizB[z, j]) + operacionresult[i, j];
                            multiplica.Rows[i].Cells[j].Value = operacionresult[i, j].ToString();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("El n° de comlumnas de la matriz A deber ser igual al n° filas de la matriz B");
            }
        }
       
        public void Escalar(DataGridView multiplicaE)
        {
            multiplicaE.RowCount = fila1;
            multiplicaE.ColumnCount = columna1;

            for (i = 0; i < fila1; i++)
            {
                for (j = 0; j < columna1; j++)
                {
                  

                        operacionresult[i, j] = matrizA[i, j] * 3;
                    multiplicaE.Rows[i].Cells[j].Value = operacionresult[i, j].ToString();
                    

                    

                }
            }
        }


    }
}