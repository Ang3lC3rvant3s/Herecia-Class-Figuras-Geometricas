using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Figura
    {

        protected byte numLados;
        protected double fbase, altura;
        protected double apotema, lado1,lado2, lado3;
        public Figura(byte numLados=0, double fbase=0.0, double altura=0.0) {
            this.numLados = numLados;
            this.fbase = fbase;
            this.altura = altura;

        }
        public Figura (byte numLados=0, double fbase=0.0, double altura=0.0, double apotema=0.0) {

            this.numLados = numLados;
            this.fbase = fbase;
            this.altura = altura;
            this.apotema = apotema;
        }

        public Figura(byte numLados = 0, double fbase = 0.0, double altura = 0.0, double l1=0, double l2=0, 
            double l3=0)
        {
            this.numLados = numLados;
            this.fbase = fbase;
            this.altura = altura;
            this.lado1 = l1;
            this.lado2 = l2;
            this.lado3 = l3;
        }
        public double calcularArea()
        {
            if(numLados==4){
                
                return fbase * altura;
            }
            else if (numLados == 3)
            {

                return fbase * altura / 2;

            }
            else if(numLados==5){
                return calcularPerimetro() * apotema / 2;

            }

            else {
                return 0;
            }
          
        }

        public double calcularPerimetro()
        {


            if (numLados == 4)
            {

                return  (fbase*2) + (altura*2) ;
            }
            else if (numLados == 3)
            {

                return lado1 + lado2 + lado3;

            }
            else if (numLados == 5)
            {
                return fbase * 5;

            }

            else
            {
                return 0;
            }



        
        }





    }





















}
