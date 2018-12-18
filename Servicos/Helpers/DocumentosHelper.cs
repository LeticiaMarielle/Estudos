using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Servicos.Helpers
{
   public class DocumentosHelper
    {

        public static bool ValidarCPF(string CPF)
        {
            var regex = new Regex(@"(\d{3}\.){2}\d{3}\-\d{2}");
            var resultado = regex.IsMatch(CPF);
            return resultado;
        }
    }
}
