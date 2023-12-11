using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario
{
    internal class Prova
    {
        public int cod, codProfessor;
        public string nome = "", materia ="", data="", matriculaEstudante = "";
        public float notas;
        public Prova(string nome, int cod, string materia, string data,float notas, string matriculaEstudante, int codProfessor)
        {
            this.nome = nome;
            this.cod = cod;
            this.materia = materia;
            this.data = data;
            this.notas = notas;
            this.matriculaEstudante = matriculaEstudante;
            this.codProfessor = codProfessor;
        }
    }
}
