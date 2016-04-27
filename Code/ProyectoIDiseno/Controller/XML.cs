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
    using System.Xml;
    using System.Xml.Serialization;
    using System.Configuration;
    using Modelo;
    using System.IO;
    public class XML : ManejoArchivos
    {


        private void createNode(string Nombre, string TipoCuenta, string Monto, string Periodo, string Moneda, string InteresAnual, string InteresGanado, XmlTextWriter writer)
        {
            writer.WriteStartElement("Cuenta");
            writer.WriteStartElement("Nombre");
            writer.WriteString(Nombre);
            writer.WriteEndElement();
            writer.WriteStartElement("TipoCuenta");
            writer.WriteString(TipoCuenta);
            writer.WriteEndElement();
            writer.WriteStartElement("Monto");
            writer.WriteString(Monto);
            writer.WriteEndElement();
            writer.WriteStartElement("Periodo");
            writer.WriteString(Periodo);
            writer.WriteStartElement("Moneda");
            writer.WriteString(Moneda);
            writer.WriteStartElement("InteresAnual");
            writer.WriteString(InteresAnual); 
            writer.WriteStartElement("InteresGanado");
            writer.WriteString(InteresGanado);
            writer.WriteEndElement();
        }
        public override bool escribirArchivo(Cuenta cuenta)
        {
            
            String filename = ConfigurationManager.AppSettings["xmlLog-Path"];

            XmlTextWriter writer;
            long id = System.DateTime.Now.Ticks;
            bool found = false;

            try
            {
                byte[] endtag = System.Text.Encoding.UTF8.GetBytes("");

                if (System.IO.File.Exists(filename))
                {
                    found = true;
                    System.IO.FileStream fs = System.IO.File.OpenWrite(filename);
                    fs.Seek(-endtag.Length, System.IO.SeekOrigin.End);
                    writer = new System.Xml.XmlTextWriter(fs, Encoding.UTF8);
                }
                else
                {
                    writer = new System.Xml.XmlTextWriter(filename, Encoding.UTF8);
                    writer.WriteStartDocument();
                    writer.WriteWhitespace("\n  ");
                    writer.WriteStartElement("Cliente" + DateTime.Now);
                }
                writer.Indentation = 4;
                writer.IndentChar = Convert.ToChar(" ");
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Cliente" + DateTime.Now);
                createNode(cuenta.Nombre, cuenta.TipoCuenta + "", cuenta.Monto + "", cuenta.Periodo + "", cuenta.Moneda + "", cuenta.InteresAnual + "", cuenta.InteresGanado + "", writer);
                writer.WriteEndElement();//END CHILD

                if (!found)
                {
                    writer.WriteEndElement();//END PARENT
                    writer.WriteEndDocument();
                }
                else
                {
                    writer.Flush();
                    writer.BaseStream.Write(endtag, 0, endtag.Length);
                }

                if (writer != null) { writer.Flush(); }
                if (writer.WriteState != System.Xml.WriteState.Closed) { writer.Close(); }
            }
            catch
            {
                throw new System.IO.FileNotFoundException("File " + filename + " not found");
                return false;
            }
            return true;

        }



    }
}

