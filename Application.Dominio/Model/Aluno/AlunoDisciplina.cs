using System;
using System.Collections.Generic;
using System.Text;


namespace Application.Dominio.Model.AlunoDisciplina
{
    public class AlunoDisciplina
    {
    
        public AlunoDisciplina(Aluno aluno,int codigoDisciplina, float nota)
        {
            this.Aluno = aluno;
            this.CodigoDisciplina = codigoDisciplina;
            this.Nota = nota;
        }

        public AlunoDisciplina(Aluno aluno, int codigoDisciplina, int quantidadeFaltas)
        {
            this.Aluno = aluno;
            this.CodigoDisciplina = codigoDisciplina;
            this.QuantidadeFaltas = quantidadeFaltas;
        }


        public int CodigoDisciplina { get; set; }
        public Aluno Aluno { get; set; }
        public int CodigoCurso { get; set; }
        public int QuantidadeFaltas { get; set; }
        public float Nota { get; set; }


    }
}
