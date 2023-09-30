using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoCuatroParcialDosLogicaUno
{
    internal class Utilidades
    {
        public bool esEntero(String pNumero)
        {
            int numero = 0;
            bool bandera = int.TryParse(pNumero, out numero);
            if(bandera)
            {
                return true;
            }
            return false;
        }

        public bool esNumero(String numero)
        {
            float num = 0;
            bool bandera=float.TryParse(numero, out num);
            if (bandera)
            {
                return true;   
            }
            return false;
        }

        public String mostrar(String mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        public int generarNumeroAleatorio(int inicio, int fin)
        {
            Random rnd = new Random();
            int numeroGenerado = rnd.Next(inicio, fin);
            return numeroGenerado;
        }
    }
}
