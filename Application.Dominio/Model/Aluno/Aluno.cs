using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
   public  class Aluno:Pessoa
    {
      public string Matricula { get; set; }
      public  Curso curso { get; set; }

        public void VisualizarNota()
        {

        }

    }
}
