using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class SueldoNegativoException : Exception
    {
        public override string ToString()
        {
            return "no se puede ingresar sueldo negativo";
        }

    }
}
