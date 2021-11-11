using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetoresMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int [] vetor = { 5, 2, 8, 9 };
            int elemento = 0;

            for (int i = 0; i < vetor.Length; i++ )
            {
                lstVetor.Items.Add("Elemento " + elemento + " = " + vetor[i]);
                elemento++;
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            int[,] matrizB = { { 2 , 4 , 6 , 8 }, { 1 , 3 , 5 , 7 } };

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    lstMatriz.Items.Add("Elemento [" + i + "," + j + " ] = " + matrizB[i, j]);
                }
            }
        }
    }
}
