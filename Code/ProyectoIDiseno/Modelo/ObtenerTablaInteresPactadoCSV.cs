﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Modelo;

    public class ObtenerTablaInteresPactadoCSV : ObtenerTablaCSV
    {
        public override StreamReader ObtenerDatosCSV()
        {
            StreamReader reader = new StreamReader(File.OpenRead(ConfigurationManager.AppSettings["tablaInteresPactadoCSV-Path"]));
            return reader;
        }


        public override SortedDictionary<float, float> ObtenerTabla(Moneda moneda)
        {
            StreamReader datosCSV = ObtenerDatosCSV();
            SortedDictionary<float, float> tablaActual = new SortedDictionary<float, float>();
            int posicionInteres = moneda.Equals(Moneda.Colon) ? 2 : 3;
            while (!datosCSV.EndOfStream)
            {
                String line = datosCSV.ReadLine();
                var values = line.Split(',');
               
                tablaActual.Add(float.Parse(values[0]), float.Parse(values[posicionInteres]));

            }
            return tablaActual;
        }
    }
}

