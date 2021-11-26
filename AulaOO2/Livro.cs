using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Livro
    {
        /*Crie uma classe Livro que represente os dados básicos de um livro. */
        public string titulo;
        public string autor;
        public string editora;
        public int ano; //ano de lançamento
        public string genero;
        public string isbn;

        public Livro(string titulo, string autor, string editora, int ano, string genero, string isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.ano = ano;
            this.genero = genero;
            this.isbn = isbn;
        }

        public void mostraTitulo()
        {
            Console.WriteLine(titulo);
        }
    }
}
