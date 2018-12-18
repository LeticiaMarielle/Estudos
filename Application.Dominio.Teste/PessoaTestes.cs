using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Servicos.Helpers;


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
            pessoa.CPF = "111.222.333-89";
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

        [Test]
        public void TestarCPFValido()
        {
            Assert.AreEqual(pessoa.CPF.Length,14);
            /**  var regex = new Regex(@"(\d{3}\.){2}\d{3}\-\d{2}");
              var resultado = regex.IsMatch(pessoa.CPF);
              Assert.IsTrue(resultado);**/
            var resultado = DocumentosHelper.ValidarCPF(pessoa.CPF);

            Assert.IsTrue(resultado);

       
        }
    }
}
