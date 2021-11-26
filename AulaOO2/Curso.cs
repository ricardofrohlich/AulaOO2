using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Curso
    {
        public string nome;
        public Curso(string nome)
        {
            this.nome = nome;
        }

        public void exibeDisciplina()
        {
            Disciplina d = new Disciplina("C#", 100);
            d.exibeInformacoes();
        }
    }
}
