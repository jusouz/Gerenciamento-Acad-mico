using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario
{
    internal class Professor
    {
        public int cod, numeroAulas, sala;
        public string nome = "";
        public Professor(string nome, int cod, int numeroAulas, int sala)
        {
            this.nome = nome;
            this.cod = cod;
            this.numeroAulas = numeroAulas;
            this.sala = sala;
        }
    }
}
