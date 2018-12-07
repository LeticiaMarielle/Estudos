using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public enum ETurno
    {
        manha = 1, tarde = 2, noite = 3
    }

    public class Funcionario
    {
        private double _salario; //atributo privado, identificar com _

        public double Salario //Proprerties
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = CalcularImpostoRenda(value);    
            }
        }

        public ETurno turno { get; set; }

        private double CalcularImpostoRenda(double salario)
        {
            if (salario >= 2500 && salario < 3500)
            {
                return salario -= salario * 0.10;
            }
            else if (salario >= 3500 && salario < 5000)
            {
                return salario -= salario * 0.20;
            }
            else if (salario >= 5000)
            {
                return salario -= salario * 0.25;
            }
            else return salario;
        }

    }
}
