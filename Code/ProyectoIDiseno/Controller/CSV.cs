﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Modelo;
    using System.IO;
    using System.Configuration;
    public class CSV : ManejoArchivos
    {
        public override bool escribirArchivo(Cuenta cuenta)
        {
            
            String csv = DateTime.Now + ","+cuenta.Nombre + "," + cuenta.TipoCuenta + "," + cuenta.Monto + "," + cuenta.Periodo + "," + cuenta.Moneda + "," + cuenta.InteresAnual + "," + cuenta.InteresGanado + "\n";
            File.AppendAllText(ConfigurationManager.AppSettings["csvLog-Path"], csv);
            return true;
        }

    }
}

