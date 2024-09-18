using ProjHeranca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjHeranca
{
    public partial class FormHeranca : Form
    {
        public FormHeranca()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            Conta o_Conta = new Conta();

            o_Conta.nroConta = 100;
            o_Conta.nomeCliente = "Bolsonaro";
            o_Conta.saldoConta = 153.3f;
        }

        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            Poupanca o_Poupanca = new Poupanca();

            o_Poupanca.nroConta = 200;
            o_Poupanca.nomeCliente = "Lucas";
            o_Poupanca.saldoConta = 1533f;
            o_Poupanca.diaRendimento = 20;
        }

        private void btnPoupancaEspecial_Click(object sender, EventArgs e)
        {
            PoupancaEspecial o_PoupancaEscial = new PoupancaEspecial();

            o_PoupancaEscial.nroConta = 202;
            o_PoupancaEscial.nomeCliente = "Pedro";
            o_PoupancaEscial.saldoConta = 1533f;
            o_PoupancaEscial.diaRendimento = 7;
            o_PoupancaEscial.valorAdicional = 1533;      
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            Colaborador o_Colaborador = new Colaborador();


            o_Colaborador.Salario = 1533f;
            o_Colaborador.Nome = "Ruan";
            o_Colaborador.Cpf = "1533-1533";
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            Gerente o_Gerente = new Gerente();

            o_Gerente.Salario = 1533f;
            o_Gerente.Nome = "Pedro";
            o_Gerente.Cpf = "1234-1234";
            o_Gerente.Setor = "Limpeza";

        }

        private void btnConstrutor_Click(object sender, EventArgs e)
        {
            Colaborador o_Colaborador = new Colaborador("Maria","1235-1245", 1533);

            //o_Colaborador.Salario = 1533f;
            //o_Colaborador.Cpf = "15-33";

            o_Colaborador.Imprimir();


        }
    }
}
