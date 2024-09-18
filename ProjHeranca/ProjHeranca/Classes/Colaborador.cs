using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHeranca.Classes
{
    public class Colaborador
    {
        //Atributos
        protected string nome;
        protected string cpf;
        protected float salario;

        public Colaborador()
        {
            
        }

        public Colaborador(string nome,
                           string cpf,
                           float salario)

        {
            this.salario = salario;
            this.cpf = cpf;
            this.nome = nome;
        }

        //Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        //Métodos
        public void Imprimir()
        {
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário: {salario}");
        }

    }
}
