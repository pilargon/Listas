using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class CantanteFamoso
    {
        //La clase debe tener un método que permita añadir objetos de tipo CantanteFamoso a la lista
       private string nombre;
       private string discoConMasVentas;
        string cantante3;
        string disco3;

        public CantanteFamoso()
        {
            
        }
        public CantanteFamoso(String nombre, String discoConMasVentas)
        {
            this.nombre = nombre;
            this.discoConMasVentas = discoConMasVentas;
        }

        public String GetNombre()
        {
            return nombre;
        }
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String GetdiscoConMasVentas()
        {
            return discoConMasVentas;
        }
        public void SetdiscoConMasVentas(String discoConMasVentas)
        {
            this.discoConMasVentas = discoConMasVentas;
        }


       

       

    }
}
