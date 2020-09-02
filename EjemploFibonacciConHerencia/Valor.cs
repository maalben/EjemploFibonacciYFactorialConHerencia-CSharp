using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploFibonacciConHerencia
{
    public class Valor
    {
        //Atributo
        private long numero;

        //Métodos setter y getter
        public void setNumero(long valor) {
            this.numero = valor;
        }

        public long getNumero() {
            return this.numero;
        }

    }
}
