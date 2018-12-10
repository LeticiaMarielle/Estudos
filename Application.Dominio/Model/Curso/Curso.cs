using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
    public class Curso
    {
        public string Descricao { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public int CargaHorariaTotal { get; set; }
        public List<Aluno> Alunos { get; set; }

    }
}
