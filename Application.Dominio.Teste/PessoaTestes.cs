using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dominio.Teste
{
    [TestFixture]
    public class PessoaTestes
    {
        Pessoa pessoa;

        public PessoaTestes()
        {
            pessoa = new Pessoa();
            pessoa.Nome = "Leticia";
            pessoa.CPF = "111";
            pessoa.Endereco.Bairro = "Centro";
            pessoa.Endereco.CEP = "35680-277";
            pessoa.Endereco.Cidade = "Divinopolis";
            pessoa.Endereco.Numero = "2";
            pessoa.Endereco.Rua = "Parana";
        }

        [Test]
        public void TestarSePessoaValida() {
            Assert.NotNull(pessoa.Nome);
            Assert.NotNull(pessoa.CPF);
        }
    }
}
