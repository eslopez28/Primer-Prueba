using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Rectangulo : Figura
    {
        private double baseR;
        private double altura;

        public Rectangulo(String ptipo, String pcolor,double pbaseR, double paltura) : base(ptipo,pcolor)
        {
            BaseR = pbaseR;
            Altura = paltura;
        }

        public Rectangulo(String pcolor, double pbaseT, double paltura)
            : this("Rectangulo", pcolor, pbaseT, paltura)
        {
        }

        public Rectangulo()
            : this("Rectangulo", "Negro",2, 1 )
        {   
        }

        public double BaseR
        {
            get { return baseR; }
            set { baseR = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double calcularArea()
        {
            double area = 0;
            area = BaseR * Altura;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimetro = 0;
            perimetro = (2 * BaseR) + (2 * Altura);
            return perimetro;
        }

        public override string dibujar()
        {
            String dibujo = "Soy un Rectangulo";
            return dibujo;
        }
    }
}
