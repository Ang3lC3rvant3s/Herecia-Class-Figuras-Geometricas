using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            byte num = Convert.ToByte(txbNumLados.Text);
            int numFigura = 0;
            double fbase = Convert.ToDouble(txbBase.Text);
            double altura = Convert.ToDouble(txbAltura.Text);
            double l1,l2,l3;
            double area, perimetro,apotema;
            Triangulo t1;
            Pentagono p1;
            Rectangulo r1;
            Cuadrado c1;
            if(num==3){
                numFigura++;
                l1 = Convert.ToDouble(txbLado1.Text);
                l2 = Convert.ToDouble(txbLado2.Text);
                l3 = Convert.ToDouble(txbLado3.Text);
                t1 = new Triangulo(fbase, altura,l1,l2,l3);
                area=t1.calcularArea();
                perimetro = t1.calcularPerimetro();
                lbFiguras.Items.Add("Figura No." + numFigura+" "+ lbMostrarFigura.Text + 
                    " Area: "+ area +" Perimetro: "+ perimetro );
            }
            else if(num == 5){
                numFigura++;
                apotema = Convert.ToDouble(txbApotema.Text);
                p1 = new Pentagono(fbase, altura,apotema);
                area = p1.calcularArea();
                perimetro = p1.calcularPerimetro();
                lbFiguras.Items.Add("Figura No." + numFigura + " " + lbMostrarFigura.Text +
                    " Area: " + area + " Perimetro: " + perimetro);

            }
            else if (num == 4 && fbase != altura)
            {
                numFigura++;
                r1 = new Rectangulo(fbase, altura);
                area = r1.calcularArea();
                perimetro = r1.calcularPerimetro();
                lbFiguras.Items.Add("Figura No." + numFigura + " " + lbMostrarFigura.Text +
                    " Area: " + area + " Perimetro: " + perimetro);
            }
            else {
                numFigura++;
                c1 = new Cuadrado(fbase, altura);
                area = c1.calcularArea();
                perimetro = c1.calcularPerimetro();
                lbFiguras.Items.Add("Figura No." + numFigura + " " + lbMostrarFigura.Text +
                    " Area: " + area + " Perimetro: " + perimetro);
            }
        }



        private void txbNumLados_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            byte num = Convert.ToByte(txbNumLados.Text);
            double fbase = Convert.ToDouble(txbBase.Text);
            double altura = Convert.ToDouble(txbAltura.Text);
            if (num == 3)
            {
                lbMostrarFigura.Text = "Triangulo";
                lbMostrarFigura.Show();
                txbLado1.Show();
                lbLado1.Show();
                txbLado2.Show();
                lbLado2.Show();
                txbLado3.Show();
                lbLado3.Show();
            }
            else if (num == 5)
            {
                lbMostrarFigura.Text = "Pentagono";
                lbMostrarFigura.Show();
                txbApotema.Show();
                lbApotema.Show();
                txbLado1.Hide();
                lbLado1.Hide();
                txbLado2.Hide();
                lbLado2.Hide();
                txbLado3.Hide();
                lbLado3.Hide();
            }
            else if(num == 4 && fbase != altura){

                lbMostrarFigura.Text = "Rectangulo";
                lbMostrarFigura.Show();
            }
            else
            {
                lbMostrarFigura.Text = "Cuadrado";
                lbMostrarFigura.Show();
                
                txbLado1.Hide();
                lbLado1.Hide();
                txbLado2.Hide();
                lbLado2.Hide();
                txbLado3.Hide();
                lbLado3.Hide();
                txbApotema.Hide();
                lbApotema.Hide();
            }


        }
       
        
    }
}
