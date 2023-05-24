using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string sexo = cb_sexo.Text;
            string cpf = tx_cpf.Text;
            double peso = Convert.ToDouble(tx_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            bool validaCPF = Validacoes.ValidaCPF(cpf);
            MessageBox.Show(validaCPF.ToString());

            Pessoa p = new Pessoa(nome, cpf, sexo, peso, altura);

            (double a, string b, string c) = p.CalcularIMC();
            lb_resultado.Text = a + b + c;

            //lb_resultado.Text += " " + Validacoes.ValidaCPF(cpf);
        }


    }

    
}

