using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploFibonacciConHerencia
{
    public class Fibonacci : Valor
    {

        public List<long> calcularFibonacci()
        {

            List<long> fibonacci = new List<long>();
            long numero = this.getNumero();

            long a = 0;
            long b = 1;
            long c = 0;

            for (long i = 0; i < numero; i++)
            {
                if (i == 0)
                {
                    fibonacci.Add(i);
                }
                a = b + c;
                b = c;
                c = a;

                fibonacci.Add(a);
            }

            return fibonacci;
        }
    }
}
