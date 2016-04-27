using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace ProyectoIDiseno
{
    static class Program
    {
        [STAThread]//gui
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();//gui
            Application.SetCompatibleTextRenderingDefault(false);//gui
            View.FormSeleccionIG fs = new View.FormSeleccionIG();//gui
            Application.Run(fs);//gui
            View.interfazConsola1 ic = new View.interfazConsola1();
            /*
            ContextCuenta cc = new ContextCuenta(new OperacionesCCorriente());
            Console.WriteLine("Corriente" + cc.executeStrategyRevisarMin(25001, 31, Moneda.Colon));
            Console.WriteLine();

            ContextCuenta cc1 = new ContextCuenta(new OperacionTPactado());
            Console.WriteLine("Pactado" + cc1.executeStrategyRevisarMin(100000, 15, Moneda.Colon));
            Console.WriteLine();

            ContextCuenta cc2 = new ContextCuenta(new OperacionesPlazo());
            Console.WriteLine("Plazo" + cc2.executeStrategyRevisarMin(100000, 89, Moneda.Colon));
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            Console.WriteLine("Mariano" + cc2.executeStrategyRevisarMin(100000, 89, Moneda.Colon));
            float valor = 1500000f;
            InteresCorriente corriente = new InteresCorriente();
            Console.WriteLine("Interes Corriente de " + valor + "   :   " + corriente.buscarInteres(valor, Moneda.Colon));
            Console.ReadKey();
            InteresPactado pactado = new InteresPactado();
            valor = 150f;
            Console.WriteLine("Interes Pactado de " + valor + "   :   " + pactado.buscarInteres(valor, Moneda.Colon));
            Console.ReadKey();
            Console.WriteLine("Interes Pactado Dolares de " + valor + "   :   " + pactado.buscarInteres(valor, Moneda.Dolar));
            Console.ReadKey();
            InteresPlazo plazo = new InteresPlazo();
            Console.WriteLine("Interes Plazo de " + valor + "   :   " + plazo.buscarInteres(valor, Moneda.Colon));
            Console.ReadKey();

            XML xmlWriter = new XML();
            Cuenta cuenta = new Cuenta("Andres", TipoCuenta.Corriente
                , 10000, 1, Moneda.Colon);

            CSV csvWriter = new CSV();
            csvWriter.escribirArchivo(cuenta);
            Console.ReadKey();

            xmlWriter.escribirArchivo(cuenta);

            Console.ReadKey();**/
            /*
            ContextCuenta cc = new ContextCuenta(new OperacionesCCorriente());
            Console.WriteLine("Corriente" + cc.executeStrategyRevisarMin(25001, 31, Moneda.Colon));
            Console.WriteLine();
            cc.executeCrearCuenta("JC", TipoCuenta.Corriente, 25001, 31, Moneda.Colon);
            Console.WriteLine();
            **/

        }
    }
}
