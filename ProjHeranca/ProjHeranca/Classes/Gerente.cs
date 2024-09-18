using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHeranca.Classes
{
    internal class Gerente: Colaborador
    {
        //Atributos
        private string setor;

        public Gerente()
        {

        }

        public Gerente(string nome,string cpf,float salario,string setor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            this.setor = setor;
        }

        //Propiedades
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
    
    }
}
