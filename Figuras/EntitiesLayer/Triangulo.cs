using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Triangulo : Figura
    {
<<<<<<< HEAD

=======
        private double baseT;
	    private double altura;
	
	public Triangulo(double pbase, double paltura, String ptipo, String pcolor):base(ptipo,pcolor){
		setBase(pbase);
		setAltura(paltura);
	}
	
	public Triangulo() : this(2, 1, "Triangulo", "negro"){
       
	}

	public double getBase() {
		return baseT;
	}

	private void setBase(double pbase) {
		baseT = pbase;
	}

	public double getAltura() {
		return altura;
	}

	private void setAltura(double paltura) {
		altura = paltura;
	}
    public override String dibujar()
    {
        String dibujo = "";
        int temp = (int)getBase();
        for (int j = 0; j < getAltura(); j++)
        {
            for (int i = 0; i < (getBase() - temp); i++)
            {
                dibujo += "*";
            }
            temp--;
            dibujo += "\n";
        }

        return dibujo;

    }
	
	
    public override double calcularArea()
    {
        double area = 0;
        area = (baseT * altura) / 2;

        return area;
>>>>>>> origin/marco-rodriguez
    }
        public override double calcularPerimetro(){
		double perimetro=0;
        double primerCat = getBase() * getBase();
        double segundoCat = getAltura() * getAltura();
        double hipotenusa = Math.Sqrt();
        perimetro = getBase() + getAltura() + hipotenusa;
        return perimetro;
	}


        public override String toString()
        {
            String estado = base.toString();
            estado += "Base: " + getBase() + "\n";
            estado += "Altura: " + getAltura() + "\n";

            return estado;
        }

}

}
