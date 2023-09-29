using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoCuatroParcialDosLogicaUno
{
    internal class Utilidades
    {
        public bool esEntero(float numero)
        {
            if(numero%1 != 0)
            {
                return false;
            }
            return true;
        }

        public bool esNumero(String numero)
        {
            float num = 0;
            if (float.TryParse(numero,out num))
            {
                return true;   
            }
            return false;
        }
    }
}
