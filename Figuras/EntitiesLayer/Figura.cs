using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class Figura
    {
        private String tipo;
	    private String id;
	    private String color;
	
	    private static int cantFig = 0;
	
	    public Figura(String ptipo, String pcolor){
		    setTipo(ptipo);
		    setId();
		    setColor(pcolor);
	    }

<<<<<<< HEAD
	    public String getTipo() {
		    return tipo;
	    }
=======
    public Figura()
    {

    }

	public String getTipo() {
		return tipo;
	}
>>>>>>> origin/marco-rodriguez

	    private void setTipo(String ptipo) {
		    tipo = ptipo;
	    }

	    public String getId() {
		    return id;
	    }

	    private void setId() {
		    cantFig++;
		    id = "Fig - "+cantFig;
	    }

	    public String getColor() {
		    return color;
	    }

	    private void setColor(String pcolor) {
		    color = pcolor;
	    }

	    public static int getCantFig() {
		    return cantFig;
	    }
	
	    public abstract double calcularArea();
	
	    public abstract double calcularPerimetro();
	
	    public abstract String dibujar();
	
	    public String toString(){
		    String estado="";
		    estado += "Tipo: "+getTipo()+"\n";
		    estado += "Id: "+getId()+"\n";
		    estado += "Color: "+getColor()+"\n";
		
		    return estado;
	    }
    }
}