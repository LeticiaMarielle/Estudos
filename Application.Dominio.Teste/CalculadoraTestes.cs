using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio.Teste
{
    [TestFixture]
   public class CalculadoraTestes
    {
       private  Calculadora calculadora;

        [SetUp]
        public void SetUp()
        {
            calculadora = new Calculadora();
        }

        [Test]
        public void TestarSomaDoisNumeros()
        {
            
            int resultado = calculadora.SomaDoisNumeros(5,3);
            Assert.That(resultado, Is.EqualTo(8));
        }
        [Test]
        public void TestarSubtracaoDoisNumeros()
        {
            int resultado = calculadora.SubstrairDoisNumeros(18, 3);
            Assert.That(resultado, Is.EqualTo(15),"Deu errado");
        }
    }
}
