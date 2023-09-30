using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoCuatroParcialDosLogicaUno
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Utilidades utilidades = new Utilidades(); 
            int numeroAleatorio = utilidades.generarNumeroAleatorio(-99999999, 99999999);
            Console.WriteLine("Juego La Queso");
            bool jugar = true;
            int ronda = 1;
            while (jugar)
            {
                Console.WriteLine("Ronda: " + ronda);
                String numeroIngresado = utilidades.mostrar("Ingrese un número: ");
                if (utilidades.esNumero(numeroIngresado))
                {                    
                    if (utilidades.esEntero(numeroIngresado))
                    {
                        int numeroUsuario = int.Parse(numeroIngresado);
                        if (numeroUsuario == numeroAleatorio)
                        {
                            Console.WriteLine("Felicitaciones");
                            jugar = false;
                        }
                        else
                        {
                            Console.WriteLine("Sigue intentando");
                            switch (ronda)
                            {
                                case 2:
                                    Console.WriteLine("Pista!");
                                    if (numeroAleatorio > 0)
                                    {
                                        Console.WriteLine("El número es mayor a cero");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El número es menor a cero");
                                    }
                                    ronda++;
                                    break;
                                case 4:
                                    if (numeroAleatorio%2 == 0)
                                    {
                                        Console.WriteLine("El número es par");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El número es impar");
                                    }
                                    ronda++;
                                    break;
                                case 6:
                                    if (numeroAleatorio > 0)
                                    {
                                        int cantidadDigitos = numeroAleatorio.ToString().Length;
                                        Console.WriteLine($"El número que debes adivinar tiene {cantidadDigitos} dígitos");
                                    }
                                    else
                                    {
                                        int cantidadDigitos = numeroAleatorio.ToString().Length - 1;
                                        Console.WriteLine($"El número que debes adivinar tiene {cantidadDigitos} dígitos");
                                    }
                                    ronda++;
                                    break;
                                case 8:
                                    int iter = 1;
                                    Console.WriteLine("Los divisores exactos del número son:");
                                    while(iter < numeroAleatorio)
                                    {
                                        if(numeroAleatorio%iter == 0)
                                        {
                                            Console.WriteLine(iter);
                                        }
                                        iter++;
                                    }
                                    ronda++;
                                    break;
                                case 10:
                                    jugar = false;
                                    Console.WriteLine("El número era" + numeroAleatorio);
                                    break;
                                default:
                                    ronda++;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Solo se admiten números enteros, siga intentando");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Solo se admiten números, siga intentando");
                }
                    
            }
            
        }
    }
}
