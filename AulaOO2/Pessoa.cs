using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Pessoa
    {
        //   Escreva uma classe Pessoa contendo todos os atributos de 
        //     uma pessoa.Faça métodos para apresentar os dados.
        private string nome;
        private string cpf;
        private int idade;

        public Pessoa(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void mostraNome()
        {
            Console.WriteLine(this.nome);
        }

        public void mostraCPF()
        {
            Console.WriteLine(this.cpf);
        }

        public void mostraIdade()
        {
            Console.WriteLine(this.idade);
        }



    }
}
