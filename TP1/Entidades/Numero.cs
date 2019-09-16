using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        private double ValidarNumero(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero) == true)
            {
                return numero;
            }

            else
            {
                return 0;
            }
        }

        public string SetNumero
        {
            set
            {
                double valor = ValidarNumero(value);

                if (valor != 0)
                {
                    this.numero = valor;
                }
            }
        }

        public string BinarioDecimal(string binario)
        {
            double numero = Convert.ToDouble(binario);

            if (numero > 0)
            {
                return Convert.ToString(numero);
            }
            else
            {
                return "Valor invalido";
            }
        }

        /*public string DecimalBinario(double numero)
        {
            double numero = 
        }

        public string DecimalBinario(string strNumero)
        {
            Convert.T
        }*/

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
    }
}
