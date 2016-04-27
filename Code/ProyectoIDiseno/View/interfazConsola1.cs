using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace ProyectoIDiseno.View
{
    internal class interfazConsola1
    {

        public void menu()
        {
            int opcion = 0;
            while (opcion != 2)
            {
                Console.WriteLine("***Menu Principal***");
                Console.WriteLine("***1. Ingresar Cuenta***");
                Console.WriteLine("***2. Salir***");
                Console.WriteLine("Ingrese opcion (numero) a ejecutar:\n");
                string opcionS = Console.ReadLine();
                try
                {
                    opcion = int.Parse(opcionS);
                    if (opcion == 1)
                    {
                        Console.Clear();
                        crearCuenta();
                        Console.ReadKey();
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("***Hasta luego***");
                        Console.ReadKey();
                        return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("***Error, favor ingresar numero***");
                }
            }


        }//End of menu

        private void crearCuenta()
        {
            try
            {
                Console.Write("Ingrese su nombre: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de tipo de cuenta: ");
                Console.WriteLine("1) corriente ");
                Console.WriteLine("2) pactada");
                Console.WriteLine("3) certificado");
                String tipoCuenta = Console.ReadLine();
                Console.Write("Ingrese el monto ");
                float monto = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el periodo: ");
                int periodo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la moneda: ");
                Console.WriteLine("1) colon ");
                Console.WriteLine("2) dolar");
                String moneda = Console.ReadLine();
                String respuesta = ControladorViews.creaCuenta(nombre, tipoCuenta, monto, periodo, moneda);
                Console.WriteLine(respuesta);
            }
            catch (Exception e) { Console.WriteLine("Verifique que lo que escribio sea correcto "); }
        }
    }
}
