using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolhaATV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            cboOpcoes.Items.Clear();
            cboOpcoes.Items.Add("Python");
            cboOpcoes.Items.Add("Java");
            cboOpcoes.Items.Add("C#");
            cboOpcoes.Items.Add("Java Script");
            cboOpcoes.Items.Add("PHP");

        }

        private void radI_CheckedChanged(object sender, EventArgs e)
        {
            cboOpcoes.Items.Clear();
            cboOpcoes.Items.Add("Azure");
            cboOpcoes.Items.Add("AWS");
            cboOpcoes.Items.Add("Cisco");
            cboOpcoes.Items.Add("Dell");
            cboOpcoes.Items.Add("Asus");
        }

        private void radE_CheckedChanged(object sender, EventArgs e)
        {
            cboOpcoes.Items.Clear();
            cboOpcoes.Items.Add("Meu Pai");
            cboOpcoes.Items.Add("Judas e o Messias Negro");
            cboOpcoes.Items.Add("Mank");
            cboOpcoes.Items.Add("Minari");
            cboOpcoes.Items.Add("Nomadland");
        }

        private void cboOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Desenvolvimento
            if (cboOpcoes.SelectedItem == "Python")
            {
                picImg.Load("python.png");
            }
            else if (cboOpcoes.SelectedItem == "Java")
            {
                picImg.Load("Java.png");
            }
            else if (cboOpcoes.SelectedItem == "C#")
            {
                picImg.Load("c.png");
            }
            else if (cboOpcoes.SelectedItem == "Java Script")
            {
                picImg.Load("javascript.png");
            }
            else if (cboOpcoes.SelectedItem == "PHP")
            {
                picImg.Load("php.png");
            }

            //Infraestrutura
            else if (cboOpcoes.SelectedItem == "Azure")
            {
                picImg.Load("azure.png");
            }
            else if (cboOpcoes.SelectedItem == "AWS")
            {
                picImg.Load("aws.png");
            }
            else if (cboOpcoes.SelectedItem == "Cisco")
            {
                picImg.Load("cisco.png");
            }
            else if (cboOpcoes.SelectedItem == "Dell")
            {
                picImg.Load("dell.png");
            }
            else if (cboOpcoes.SelectedItem == "Asus")
            {
                picImg.Load("asus.png");
            }

            //Entretenimento
            else if (cboOpcoes.SelectedItem == "Meu Pai")
            {
                picImg.Load("meupai.png");
            }
            else if (cboOpcoes.SelectedItem == "Judas e o Messias Negro")
            {
                picImg.Load("judas.png");
            }
            else if (cboOpcoes.SelectedItem == "Mank")
            {
                picImg.Load("mank.png");
            }
            else if (cboOpcoes.SelectedItem == "Minari")
            {
                picImg.Load("minari.png");
            }
            else if (cboOpcoes.SelectedItem == "Nomadland")
            {
                picImg.Load("nomadland.png");
            }
        }
    }
}
