using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
   public  class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Pessoa()
        {
            Endereco = new Endereco();
        }

    }
}
