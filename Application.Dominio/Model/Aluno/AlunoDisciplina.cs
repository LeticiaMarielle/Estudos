using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio.Model.Aluno
{
    public class AlunoDisciplina
    {
    
        public AlunoDisciplina(int codigoAluno,int codigoDisciplina, float nota)
        {
            this.CodigoAluno = codigoAluno;
            this.CodigoDisciplina = codigoDisciplina;
            this.Nota = nota;
        }

        public AlunoDisciplina(int codigoAluno, int codigoDisciplina, int quantidadeFaltas)
        {
            this.CodigoAluno = codigoAluno;
            this.CodigoDisciplina = codigoDisciplina;
            this.QuantidadeFaltas = quantidadeFaltas;
        }


        public int CodigoDisciplina { get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoCurso { get; set; }
        public int QuantidadeFaltas { get; set; }
        public float Nota { get; set; }


    }
}
