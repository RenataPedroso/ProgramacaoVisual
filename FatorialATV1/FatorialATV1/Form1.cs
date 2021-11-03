using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatorialATV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, contador;
            int fatorial = 1;
            
            int.TryParse(txtNumero.Text, out numero);

            for (contador = numero; contador >= 1; contador--)
            {
                fatorial *= contador;
                lstFatorial.Items.Add(contador);
            }
            lstFatorial.Items.Add(numero + "!" + " = " + fatorial);
        }
    }
}
