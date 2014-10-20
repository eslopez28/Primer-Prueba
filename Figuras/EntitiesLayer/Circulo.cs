using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Circulo : Figura
    {
        private double radio;

        public Circulo(String ptipo, String pcolor, double pradio)
            : base(ptipo, pcolor)
        {
            Radio = pradio;
        }

        public Circulo(String pcolor, double pradio)
            : this("Circulo", pcolor, pradio)
        {
        }

        public Circulo()
            : this("negro", 2)
        {
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double calcularArea()
        {
            double area = 0;
            area = Math.Pow(Radio, 2) * Math.PI;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimetro = 0;
            perimetro = 2 * Radio * Math.PI;
            return perimetro;
        }

        public override string dibujar()
        {
            String dibujo = "Soy un circulo";
            return dibujo;
        }
    }
}
