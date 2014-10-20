using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace BLL
{
    public class Gestor
    {
        public String crearFigura(int pseleccion)
        {
            Figura objFigura=null;
            if (pseleccion == 1)
            {
                objFigura = new Triangulo();
            }
            else if (pseleccion == 2)
            {
                objFigura = new Rectangulo();
            }
            return objFigura.Tipo;
        }
    }
}
