﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Modelo
{
    using Modelo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class InteresPlazo : ICuenta
	{
        public IObtenerTablaAPI IObtenerTablaAPI
        {
            get;
            set;
        }
        

        public float buscarInteres(float cantidad, Moneda moneda)
        {
            ObtenerTablaInteresPlazoCSV tablaParaApi = new ObtenerTablaInteresPlazoCSV();
            IObtenerTablaAPI = tablaParaApi;
            SortedDictionary<float, float> tabla = IObtenerTablaAPI.ObtenerTabla(moneda);
            float interes = tabla.FloorEntry(cantidad).Value;
            return interes;
        }
    }
}

