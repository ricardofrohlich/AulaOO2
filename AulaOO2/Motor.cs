using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Motor
    {
        /*Crie uma classe chamada Motor que possua três atributos visíveis 
         * apenas na própria classe, são eles: nomeFabricante, potência e tipo.
Também deverão ser criados dois métodos visíveis a qualquer classe, sendo que
        um desses métodos deverá associar valores aos atributos e outro 
        método deverá retornar o conteúdo desses atributos. Em uma outra 
        classe deverá ser
        instanciada a classe Motor e apresentado na tela os valores dos atributos 
        retornados pelo método correspondente da classe Motor.
        */
        private string _nomeFabricante;
        private int _potencia;
        private string _tipo;

       /* public string getNomeFabricante()
        {
            return this._nomeFabricante;
        }

        public void setNomeFabricante(string nomeFabricante)
        {
            this._nomeFabricante = nomeFabricante;
        }*/

        public int potencia
        {
            get
            {
                return _potencia;
            }
            set
            {
                _potencia = value;
            }
        }

        public string nomeFabricante
        {
            set
            {
                _nomeFabricante = value;
            }
            get
            {
                return _nomeFabricante;
            }

        }

        public string tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public void mostraDados()
        {
            Console.WriteLine(_nomeFabricante);
            Console.WriteLine(_potencia);
            Console.WriteLine(_tipo);
        }

    }
}
