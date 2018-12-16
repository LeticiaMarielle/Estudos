using Application.Dominio.Model.AlunoDisciplina;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
    public class Disciplina
    {
        public string Descricao;
        public int Codigo;
        public int CargaHoraria;
        public Professor Professor { get; set; }
        public List<AlunoDisciplina> Alunos { get; set; }

    }
}
