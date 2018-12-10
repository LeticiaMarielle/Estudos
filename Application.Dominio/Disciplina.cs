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
        public List<Professor> professores;
    }
}
