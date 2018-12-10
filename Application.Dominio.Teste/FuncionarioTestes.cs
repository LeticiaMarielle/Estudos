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
           // funcionario.Salario =3500;
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
        public void TestarCalculoImpostoRendaSalarioMenorIgual2500() {
            funcionario.Salario =2500;
            Assert.That(funcionario.Salario, Is.EqualTo(2250));
        }

        [Test]
        public void TestarCalculoImpostoRendaSalarioMenorIgual3500()
        {
            funcionario.Salario = 3500;
            Assert.That(funcionario.Salario, Is.EqualTo(2800));
        }

        [Test]
        public void TestarCalculoImpostoRendaSalarioMaiorIgual5000()
        {
            funcionario.Salario = 5000;
            Assert.That(funcionario.Salario, Is.EqualTo(3750));
        }

    }
}
