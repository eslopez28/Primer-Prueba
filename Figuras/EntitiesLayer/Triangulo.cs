using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Triangulo : Figura
    {
        private double baseT;
        private double altura;

        public Triangulo(String ptipo, String pcolor, double pbaseT, double paltura)
            : base(ptipo, pcolor)
        {
            BaseT = pbaseT;
            Altura = paltura;
        }

        public Triangulo(String pcolor, double pbaseT, double paltura)
            : this("Triangulo", pcolor, pbaseT, paltura)
        {
        }

        public Triangulo()
            : this("Negro", 2, 1)
        {

        }
        
        public double BaseT
        {
            get { return baseT; }
            set { baseT = value; }
        }
       
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double calcularArea()
        {
            double area = 0;
            area = (BaseT * Altura) / 2;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimetro = 0;
            double hipotenusa = 0;
            hipotenusa = Math.Sqrt( (Math.Pow(BaseT,2))+ (Math.Pow(Altura,2)) );
            perimetro = BaseT + Altura + hipotenusa;

            return perimetro;
        }

        public override string dibujar()
        {
            String dibujo = "Soy un Triangulo";
            return dibujo;
        }
    }
}
