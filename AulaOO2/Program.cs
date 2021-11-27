using System;

namespace AulaOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /* Livro l = new Livro("Senhor dos anéis", "Autor teste", "Editora teste", 1980, "Ficção", "ABC234567890");
             /* l.titulo = "Senhor dos anéis";
             l.editora = "Editora teste";
             l.autor = "Autor teste";
             l.ano = 1980;
             l.genero = "Ficção";
             l.isbn = "ABC234567890";
             Console.WriteLine("Titulo "+l.titulo+" Editora "+l.editora);
             l.mostraTitulo();
            Pessoa p = new Pessoa("RICADO", "123456789", 25);
            p.mostraNome();
            p.mostraCPF();
            p.mostraIdade();
            //p.nome = "Astolfo";
            p.setNome("Astolfo");
            //p.mostraNome();
            Console.WriteLine("Mostrando o retorno da função getnome = "+p.getNome());
            
            Curso c = new Curso("Capacitação");
            c.exibeDisciplina();*/
            Motor m = new Motor();
            //m.setNomeFabricante("Britania");
            m.nomeFabricante = "Britania";
            m.potencia = 150;
            m.tipo = "Elétrico";
            //m.mostraDados();

            Console.WriteLine("Fabricante: "+m.nomeFabricante);
            Console.WriteLine("Potencia: "+m.potencia);
            Console.WriteLine("Tipo: "+m.tipo);




        }
    }
}
