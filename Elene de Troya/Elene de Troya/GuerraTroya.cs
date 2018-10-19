using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class GuerraTroya
    {
        static void Main(string[] args)
        {
            List<Griego> listaGriegos = new List<Griego>();
            Griego g1 = new Griego("Aquiles", 34, 4, false, false);
            Griego g2 = new Griego("Agamenon", 5, 4, false, false);
            Griego g3 = new Griego("Ajax", 98, 4, false, false);
            listaGriegos.Add(g1);
            listaGriegos.Add(g2);
            listaGriegos.Add(g3);
            Caballo caballo = new Caballo(20, 0, new List<Griego>());
            caballo.MontarseEnCaballo(g1);
            caballo.MontarseEnCaballo(g2);
            caballo.MontarseEnCaballo(g3);
            caballo.MostrarCaballo();
            Troyano t1 = new Troyano();
            Menu();
            Console.ReadLine();

        }
        static public void Menu()
        {
            int menuSelecion;
            const int CREAR = 1, EXIT = 3, RETIRARSE = 2;

            do
            {
                Console.WriteLine("Elige una opción: " +
                              "\n1. Crear Troyano!" +
                              "\n2. Retirarse" +
                              "\n3. Salir.");
                menuSelecion = Convert.ToInt32(Console.ReadLine());
            } while (menuSelecion < 1 || menuSelecion > 3);

            switch (menuSelecion)
            {
                case CREAR:
                    Registrar();
                    break;
                case RETIRARSE:
                    Troyano t1 = new Troyano();
                    t1.Retirarse();
                    break;
                case EXIT:
                    break;

            }
        }
        static public void Registrar()
        {
            string respuesta;
            Troyano t1;
            do
            {
                Console.WriteLine("Escribe el nombre del troyano! ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Escribe la edad del troyano!");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe la fuerza del troyano!");
                int f = Convert.ToInt32(Console.ReadLine());
                t1 = new Troyano(nombre, edad, f);
                t1.MostrarDatos();
                Console.WriteLine("Quieres crear otro Troyano?:S/N");
                respuesta = Console.ReadLine();
            }
            while (respuesta.ToUpper() == "S");
            {
                Console.WriteLine("Adios!");
            }

        }



    }
}
