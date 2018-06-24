using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{

    public delegate double Operador<T>(T a, T b);

    public static class Calculadora
    {


        public static double Sumar(double numero1, double numero2) { return numero1 + numero2; }

        public static double Menos(double numero1, double numero2) { return numero1 - numero2; }

        public static double Dividir(double numero1, double numero2) { return numero1 / numero2; }

        public static double Multiplicar(double numero1, double numero2) { return numero1 * numero2; }

        public static int Factorial(int numero)
        {
            int resultado = 0;


            if (numero > 0)
            {

                for(int i = numero; i > 1; i++)
                {

                    resultado += i * (i - 1);

                }

            }


            return resultado;

        }

        public static double Promedio(double Acumulador, int cantidad) { return Acumulador / cantidad; }

        public static double CalcularDosObject<T>(T numero1, T numero2, Operador<T> operador, out bool isValid)
        {
            double resultado = 0;

            isValid = true;

            try
            {
                //INVOCO AL METODO
                resultado = operador.Invoke(numero1, numero2);
            }

            catch(ArgumentNullException e)
            {
                isValid = false;
                throw e;
            }

            catch (ArgumentException e)
            {
                isValid = false;
                throw e;
            }

            catch(FormatException e)
            {
                isValid = false;
                throw e;
            }

            catch(Exception e)
            {
                isValid = false;
                throw e;
            }

            return resultado;
        }

    }
}
