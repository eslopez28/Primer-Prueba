using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class Figura
    {
        private String id;
        private String tipo;
        private String color;

        private static int cantFig = 0;
	
	    public Figura(String ptipo, String pcolor){
            Id ="Fig-"+ ++cantFig;
            Tipo = ptipo;
            Color = pcolor;
	    }

        public String Id
        {
            get { return id; }
            set 
            { 
                id = value; 
            }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }
	
	
	    public abstract double calcularArea();
	
	    public abstract double calcularPerimetro();

        public abstract String dibujar();
	   
    }
}