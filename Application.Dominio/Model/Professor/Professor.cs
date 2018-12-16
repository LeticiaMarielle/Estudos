using Application.Dominio.Model.AlunoDisciplina;
using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
    public class Professor:Funcionario
    {
        public string Registro;
        public string Formacao;
       


        public void LancarNota(Aluno aluno, Disciplina disciplina , float nota )
        {
            disciplina.Alunos.Find(lnq => lnq.Aluno.Matricula == aluno.Matricula ).Nota = nota;
           
        }

        public AlunoDisciplina LancarFaltas(Aluno codigoAluno, int codigoDisciplina, int quantidadeFaltas)
        {
            return new AlunoDisciplina(codigoAluno, codigoDisciplina, quantidadeFaltas);
        }
    }
       
}
