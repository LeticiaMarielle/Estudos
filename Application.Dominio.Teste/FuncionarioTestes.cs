using Dominio;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dominio.Teste
{
    [TestFixture]
    public class FuncionarioTestes
    {
        private Funcionario funcionario;

        [SetUp]
        public void SetUp()
        {
            funcionario = new Funcionario();
            funcionario.Salario = 5500;
            funcionario.turno = ETurno.manha;
        }

        [Test]
        public void TestarSeFuncionarioPossuiTurnoValido(){
            Assert.AreEqual(ETurno.manha, funcionario.turno);
        }

        [Test]
        public void TestarErroTurnoInvalido() {
            Assert.AreNotEqual(5,funcionario.turno,"Turno 5 inválido");
            Assert.AreNotEqual(ETurno.tarde, funcionario.turno, "Turno tarde inválido");
            Assert.AreNotEqual(ETurno.noite, funcionario.turno, "Turno noite inválido");
        }

        [Test]
        public void TestarCalculoImpostoRenda() {
            Assert.That(funcionario.Salario, Is.EqualTo(2250));
        }

    }
}
