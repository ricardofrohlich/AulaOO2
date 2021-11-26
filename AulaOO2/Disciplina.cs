using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Disciplina
    {
        /*Crie uma classe chamada Disciplina que contenha os atributos nome da 
         * disciplina e carga horária. Tanto o nome da disciplina quanto a carga
         * horária são definidos pelo construtor da própria classe. Além do 
         * ,construtor, crie um método para exibir esses dados após a sua atribuição.
         * O método para exibir os dados deverá ser chamado em uma outra classe
         * */
        private string nome;
        private int ch;

        public Disciplina(string nome, int ch)
        {
            this.nome = nome;
            this.ch = ch;
        }

        public void exibeInformacoes()
        {
            Console.WriteLine("O nome da diciplina é: "+this.nome+" com carga horárioa = "+this.ch);
        }

    }
}
