using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Troyano
    {
        private string nombre;
        private int edad;
        private bool herido;
        private bool muerto;
        private int f;

        //constructores con parametros y vacios
        //Deberá comprobar que los valores dados son válidos y en caso contrario poner 
        //como edad 25 y como fuerza 5.

        public Troyano(String nombre, int edad, int f)
        {
            this.nombre = nombre;
            if (ComprobarEdad(edad))
            {
                this.edad = 25;
            }
            else
            {
                this.edad = edad;
            }
            if (ComprobarFuerza(f))
            {
                this.f = 5;
            }
            else
            {
                this.f = f;
            }
            herido = false;
            muerto = false;
        }
        //f)Crea un segundo constructor sin parámetros que ponga como nombre “TroyanoX”, 
        //edad 18 y fuerza 10.
        public Troyano()
        {
            nombre = "TroyanoX";
            edad = 18;
            f = 10;
        }

        //Get y set
        public String GetNombre()
        {
            return nombre;
        }
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public bool GetHerido()
        {
            return herido;
        }
        public void SetHerido()
        {
            this.herido = herido;
        }
        public bool GetMuerto()
        {
            return muerto;
        }
        public void SetMuerto()
        {
            this.muerto = muerto;
        }
        public int GetF()
        {
            return f;
        }
        public void SetF(int f)
        {
            this.f = f;
        }

        public bool Retirarse()
        {
            Console.WriteLine("Accion:Retirarse");
            Console.WriteLine("Troyano:Paris");
            Console.WriteLine("Edad:19 Fuerza:10");
            Console.WriteLine("Esta herido y los guerreros Troyanos NUNCA se retiran!!!");
            return true;
        }

        //que devuelva true si la edad está entre 15 y 60 (ambos inclusive), false en caso contrario.
        public Boolean ComprobarEdad(int edad)
        {
            if (edad >= 15 || edad <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // boolean ComprobarFuerza(int f) que devuelve true si la fuerza está entre 1 y 10 (ambos inclusive),
        //false en caso contrario.
        public Boolean ComprobarFuerza(int f)
        {
            if (f >= 1 || f <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fuerza: " + f);
            Console.WriteLine("Herido: " + herido);
            Console.WriteLine("Muerto: " + muerto);
        }



    }
}
