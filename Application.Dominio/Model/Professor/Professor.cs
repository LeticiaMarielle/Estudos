using Application.Dominio.Model.AlunoDisciplina;
using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
    public class Professor:Funcionario
    {
        public string Registro { get; set; }
        public string Formacao { get; set; }

        public void LancarNota(Aluno aluno, Disciplina disciplina , float nota )
        {
            disciplina.Alunos.Find(lnq => lnq.Aluno.Matricula == aluno.Matricula).Nota = nota; /*pesquisando por um aluno na lsita de alunos pela matricula, e recebendo a nota informada*/
           
        }

        public AlunoDisciplina LancarFaltas(Aluno codigoAluno, int codigoDisciplina, int quantidadeFaltas)
        {
            return new AlunoDisciplina(codigoAluno, codigoDisciplina, quantidadeFaltas);
        }
    }
       
}
