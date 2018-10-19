using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Griego
    {

        private string nombre;
        private int edad;
        private bool herido;
        private bool muerto;
        private int f;
        private bool retirarse;

        public Griego(String nombre, int edad, int f, bool herido, bool muerto)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.f = f;
            this.herido = herido;
            this.muerto = herido;
        }
        public Griego()
        {
            nombre = "GriegoX";
            edad = 20;
            f = 8;
        }
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

        public void Retirarse(bool retirarse)
        {
            if (herido && !muerto)
            {
                this.retirarse = retirarse;
            }
            else
            {

                Console.WriteLine("Accion:Retirarse");
                Console.WriteLine("Griego:Ulises");
                Console.WriteLine("Edad:28 Fuerza:3");
                Console.WriteLine("Esta herido RETIRADA");
                this.retirarse = false;
            }
        }
        public void MostrarGriego()
        {
            Console.WriteLine("Facción:Griegos\nGuerrero: " + nombre + "\nEdad: " + edad + "\nFuerza: " + f);
            if (herido && !muerto)
            {
                Console.WriteLine("El combatiente esta herido");
            }
            else if (muerto)
            {
                Console.WriteLine("El combatiente ha muerto");
            }
            else if (retirarse)
            {
                Console.WriteLine("El combatiente se ha retirado");
            }
            else
            {
                Console.WriteLine("Estado: Combatiente sano y en activo");
            }
        }




    }
}
