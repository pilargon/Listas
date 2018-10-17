using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_list
{
    class Compra
    {
        static void Main(string[] args)
        {//Método CreaLista:
         //Esta función recibirá por parámetro la lista que crearemos en el programa y la devolverá escrita. 
            List<string> compra = new List<string>();
            CrearLista(compra);
            MostrarLista(compra);
            OrdenarLista(compra);
            OrdenarListaReves(compra);
            BorrarLista("Manzanas",compra);
            Console.WriteLine(ContarElementos(compra));
            Console.ReadLine();

        }

        public static void CrearLista(List<string> compra)
        {
            //a;adir datos a la lista por parametro
            compra.Add("Manzanas");
            compra.Add("Carne");
            compra.Add("Leche");
            compra.Add("Galletas");
            compra.Add("Tomates");
            compra.Add("Platanos");
        }
        //Método MostrarLista:
        //Esta función simplemente recibirá la lista por parámetro y la mostrará en pantalla.

        public static void MostrarLista(List<string> compra)
        {
            foreach (String x in compra)
            {
                Console.WriteLine("\t" + x);
            }
        }

        //Crea un método OrdenarLista:
        //Ordena alfabéticamente la lista que reciba por parámetro.
        public static void OrdenarLista(List<string> compra)
        {
            Console.WriteLine("Elementos de la lista ordenados alfabeticamente: ");
            compra.Sort();//Ordena alfabeticamente
            foreach (string x in compra)
            {
                Console.WriteLine("\n" + x);
            }
        }
        public static void OrdenarListaReves(List<string> compra)
        {
            Console.WriteLine("Elementos de la lista ordenados alfabeticamente al reves: ");
            compra.Reverse();//Ordena alfabeticamente en sentido contrario
            foreach (string x in compra)
            {
                Console.WriteLine("******" + x);
            }
        }
        //Crea un método BorrarDeLaLista:
        //Recibirá un elemento y una lista por parámetro.Si encuentra el elemento en la lista lo borrara.
        public static void BorrarLista(string elemento, List<string> compra)
        {
            Console.WriteLine("Vamos a borrar un elemento 'Manzana' de la lista");
            compra.Remove(elemento);//Ordena alfabeticamente
            MostrarLista(compra);
        }
        //Crea un método ContarElementos:
        //Recibe una lista por parámetro y devuelve la cantidad de elementos en ella.
        public static int ContarElementos(List<string> compra)
        {
            Console.WriteLine("Nos va a contar los elementos de la lista");
            return compra.Count();           
        }



    }
}
