using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace tienda
{
    class Program
    {

        static void Main(string[] args)
        {
            int valMax = 0; int valMin = 0;
            string nomPrecioMax = "", nomPrecioMin = "";

            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("ingresa Cuantos productos a valorar");
            System.Console.WriteLine("-----------------------------------");
            int cantProductos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantProductos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("Ingresa el nombre del producto {0}",i);
                System.Console.WriteLine("-----------------------------------");
                string nomproductos1 = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("ingresa el valor del producto {0}", i);
                System.Console.WriteLine("-----------------------------------");
                int totalValor = Convert.ToInt32(Console.ReadLine());


                NomProductos result1 = new NomProductos();
                string Resultproductos = result1.igu(nomproductos1);
                

                valProducto result2 = new valProducto();
                int ResultValor = result2.igu(totalValor);

                if (i == 1)
                {
                    
                    valMax = ResultValor;
                    valMin = ResultValor;
                }
                if (ResultValor > valMax) 
                {
                    nomPrecioMax = Resultproductos;
                    valMax = ResultValor; 
                }
                if (ResultValor < valMin) 
                {
                    nomPrecioMin = Resultproductos;
                    valMin = ResultValor; 
                }
                
                totalValor= 0;
                



            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************************");
            Console.WriteLine("el nombre del producto mas Costoso es " + nomPrecioMax + " Con un Valor de: " + valMax);
            Console.WriteLine("************************************************");
            Console.WriteLine("el nombre del producto mas barato es " + nomPrecioMin + " Con un Valor de: " + valMin);
            Console.WriteLine("************************************************");



        }

        class NomProductos
        {
            private string producto;


            public string igu(string aproducto)
            {
                producto = aproducto;
                

                return producto;

            }
        }

        class valProducto
        {
            private int valor;


            public int igu(int aValor)
            {
                valor = aValor;
                



                return valor;

            }
        }

    }
}
