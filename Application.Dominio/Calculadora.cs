using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dominio
{
    public class Calculadora
    {

        public int SomaDoisNumeros(int numero1, int numero2)
        {
            int ResultadoSoma = numero1 + numero2;

            return ResultadoSoma;
        }

        public int SubstrairDoisNumeros(int numero1, int numero2)
        {
            int ResultadoSubstracao = numero1 - numero2;
            return ResultadoSubstracao;
        }
    }
}
