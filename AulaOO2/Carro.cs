using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO2
{
    class Carro
    {
        public int _velocidade;
        public int _velocidademaxima;
        private int _portas;

        public int portas { get => portas; set => _portas = value; }

        public void acelera()
        {
            if (_velocidade < _velocidademaxima)
            {
                this._velocidade++;
            }
            
        }
    }
}
