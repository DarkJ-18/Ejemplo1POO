using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1POO
{
   public class Matematicas
    {

        private double numero1;
        private double numero2;
       
        public void SetNumero1(double valor)
        {
            this.numero1 = valor;
        }

        public double GetNumero1()
        {
            return this.numero1;
        }


        public  void SetNumero2(double valor)
        {
            this.numero2 = valor;
        }

        public double GetNumero2()
        {
            return this.numero2;
        }


        public double sumar()
        {
            return (this.GetNumero1() + this.GetNumero2());
        }

        public double restar()
        {
            return (this.GetNumero1() - this.GetNumero2());
        }

        public double dividir()
        {
            return (this.GetNumero1() / this.GetNumero2());
        }

        public double multiplicar()
        {

            return (this.GetNumero1() * this.GetNumero2());
        }
    }
}
