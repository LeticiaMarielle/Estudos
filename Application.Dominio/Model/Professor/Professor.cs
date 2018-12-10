using Application.Dominio.Model.Aluno;
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


        public AlunoDisciplina LancarNota(int codigoAluno, int codigoDisciplina , float nota )
        {
            return new AlunoDisciplina(codigoAluno, codigoDisciplina, nota);
        }

        public AlunoDisciplina LancarFaltas(int codigoAluno, int codigoDisciplina, int quantidadeFaltas)
        {
            return new AlunoDisciplina(codigoAluno, codigoDisciplina, quantidadeFaltas);
        }
    }
       
}
