using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        { // Lee por consola los números que introduzca el usuario. 
          // Si el número introducido es decimal lo guardará en una lista de números decimales,.
          //Si no es decimal entonces los guardará en una lista de ints.

            //List<int> Entero = new List<int>();
            //List<double> Decimal = new List<double>();
            //IntroducirNum(Entero, Decimal);
            //MostrarListas(Entero, Decimal);
            //Console.WriteLine("El numero de enteros es: " + ContarListasE(Entero));
            ////Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("El numero de decimales es: " + ContarListasD(Decimal));
            //Console.WriteLine("La suma de los enteros es: " + SumarListasE(Entero));
            //Console.WriteLine("La media de todos los numeros es: " + (SumarListasE(Entero) + SumarListasD(Decimal)) / (ContarListasE(Entero) + ContarListasD(Decimal)));

            List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>();
            CrearLista(listaCantantesFamosos);
            MostrarLista(listaCantantesFamosos);           
            Insertar(listaCantantesFamosos);
            
            Console.ReadLine();

        }
        public static void CrearLista(List<CantanteFamoso> listaCantantesFamosos)
        {
            CantanteFamoso cantante1 = new CantanteFamoso();
            cantante1.SetNombre("Falete");
            cantante1.SetdiscoConMasVentas("Disco de Falete");
            listaCantantesFamosos.Add(cantante1);
            CantanteFamoso cantante2 = new CantanteFamoso();
            cantante2.SetNombre("Camaron");
            cantante2.SetdiscoConMasVentas("Disco de Camaron");
            listaCantantesFamosos.Add(cantante2);
        }
        public static void MostrarLista(List<CantanteFamoso> listaCantantesFamosos)
        {
            foreach (CantanteFamoso x in listaCantantesFamosos)
            {
                Console.WriteLine(x.GetNombre());
                Console.WriteLine(x.GetdiscoConMasVentas());
            }
        }
        public static void Insertar(List<CantanteFamoso> listaCantantesFamosos)
        {
            string respuesta;
            do
            {
                CantanteFamoso cantante3 = new CantanteFamoso();

                Console.WriteLine("\nDime un cantante famoso");
                cantante3.SetNombre(Console.ReadLine());
                listaCantantesFamosos.Add(cantante3);

                Console.WriteLine("Dime un disco del famoso");
                cantante3.SetdiscoConMasVentas(Console.ReadLine());
                listaCantantesFamosos.Add(cantante3);

                Console.WriteLine("Quieres seguir escribiendo cantantes?:S/N");
                respuesta= Console.ReadLine();
            }
            while (respuesta.ToUpper() == "S");          
               
        }
       
        //public static void IntroducirNum(List<int> Entero, List<double> Decimal)
        //{
        //    string num;
        //    do
        //    {
        //        Console.WriteLine("Dame numeros positivos");
        //        num = Console.ReadLine();

        //        if (num.Contains(".") || num.Contains("'"))
        //        {
        //            Decimal.Add(Convert.ToDouble(num.Replace(".", ",")));//No me deja poner coma por teclado,
        //            //y al tranformarlo en numero me quita la coma,asi que reemplazmos por punto
        //        }
        //        else if (!num.Contains(".") && !num.Contains("'") && !num.Contains("0") && !num.Contains("-"))
        //        {
        //            Entero.Add(Convert.ToInt32(num));
        //        }
        //        //else //TODO: JAJAJ
        //        //{
        //        //    Console.WriteLine("Has introducido una letra");
        //        //}
        //    }
        //    while (Convert.ToDouble(num) >= 0);
        //}

        //public static void MostrarListas(List<int> Entero, List<double> Decimal)
        //{
        //    Console.WriteLine("La lista de enteros es: ");
        //    foreach (int x in Entero)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    Console.WriteLine("La lista de decimales es: ");
        //    foreach (double x in Decimal)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        //public static int ContarListasE(List<int> Entero)
        //{
        //    return Entero.Count();
        //}
        //public static double ContarListasD(List<double> Decimal)
        //{
        //    return Decimal.Count();
        //}
        //public static int SumarListasE(List<int> Entero)
        //{
        //    return Entero.Sum();
        //}
        //public static double SumarListasD(List<double> Decimal)
        //{
        //    return Decimal.Sum();
        //}



    }




}














