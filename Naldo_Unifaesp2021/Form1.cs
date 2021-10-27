using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naldo_Unifaesp2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            String Sexo = null;
            if (checkBox1.Checked == true)
            { Sexo = "MASCULINO"; }
            else if (checkBox2.Checked == true)
            { Sexo = "FEMININO"; }

            textBox1.Text = "Nome: " + textBox_nome.Text.ToString() + newLine +
                "Sobrenome: " + textbox_sobrenome.Text.ToString() + newLine +
                "Data de nascimento: " + dateTimePicker1.Text.ToString() + newLine +
                "Sexo: " + Sexo +
                "Endereço: " + textBox_endereco.Text.ToString() + newLine +
                "Cidade: " + textBox_cidade.Text.ToString() + newLine +
                "Estado: " + textBox_estado.Text.ToString() + newLine +
                "CEP: " + textBox_CEP.Text.ToString() + newLine +
                "Telefone para contato: " + textBox_telefone.Text.ToString() + newLine +
                "E-mail: " + textbox_email.Text.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
