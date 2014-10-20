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

        public Rectangulo(double pbaseR, double paltura, String ptipo, String pcolor) : base(ptipo,pcolor)
        {
            BaseR = pbaseR;
            Altura = paltura;
        }

        public Rectangulo(double pbaseR, double paltura, String pcolor):this(pbaseR,paltura,"Rectangulo",pcolor)
        {
        }

        public Rectangulo()
            : this(2, 1, "Rectangulo", "Negro")
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
