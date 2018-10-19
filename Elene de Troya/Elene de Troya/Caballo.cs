using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Caballo
    {
        private int capacidad;//representa el número de guerreros griegos que puede haber dentro 
        //del caballo. No se podrá cambiar una vez le hemos dado valor.
        private int ocupacion;//representa el número actual de griegos en el caballo
        private List<Griego> ocupantes;//lista de objetos de la clase Griego.

        //CAPACIDAD NO ES CTE.,PERO NO CAMBIA,POR LO QUE NO SE DEBE HACER SET

        public Caballo(int capacidad, int ocupacion, List<Griego> ocupantes)
        {          
            this.capacidad = capacidad;
            this.ocupacion = ocupacion;
            this.ocupantes = ocupantes;           
        }

        public int BuscarGriego(string nombre)
        {
            int posicion = -1;
            foreach (Griego ocupante in ocupantes)
            {
                if (ocupante.GetNombre() == nombre)
                {
                    posicion = ocupantes.IndexOf(ocupante);
                }
            }
            return posicion;
        }
       
        //que reciba como parámetro un Griego y lo meta en la lista de ocupantes (si hay sitio).
        public void MontarseEnCaballo(Griego griego)
        {   

            if(ocupantes.Count()< capacidad)
            {
                ocupantes.Add(griego);
                Console.WriteLine("Guerrero griego "+ griego.GetNombre()+ "montado a caballo");
            }
            else
            {
                Console.WriteLine("No hay sitio");
            }
        }

        public void MostrarCaballo()
        {
            Console.WriteLine("Capacidad: " + capacidad);
            Console.WriteLine("Ocupacion: " + ocupacion);
            Console.WriteLine("Ocupantes: " + ocupantes);  
            foreach(Griego persona in ocupantes)
            {
                persona.MostrarGriego();
            }
            
        }



    }
}
