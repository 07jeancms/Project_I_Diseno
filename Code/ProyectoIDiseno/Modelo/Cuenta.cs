﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Modelo
{
    using Controller;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Modelo;

    public class Cuenta
    {
        private float interesGanado;
        private float interesAnual;
        private Moneda moneda;
        private int periodo;
        private float monto;
        private TipoCuenta tipoCuenta;
        private string nombre;


        public float InteresGanado
        {
            get
            {
                return interesGanado;
            }
            set
            {
                interesGanado = value;
            }
        }

        public float InteresAnual
        {
            get
            {
                return interesAnual;
            }
            set
            {
                interesAnual = value;
            }
        }

        public Moneda Moneda
        {
            get
            {
                return moneda;
            }
            set
            {
                moneda = value;
            }
        }

        public int Periodo
        {
            get
            {
                return periodo;
            }
            set
            {
                periodo = value;
            }
        }

        public float Monto
        {
            get
            {
                return monto;
            }
            set
            {
                monto = value;
            }
        }

        public TipoCuenta TipoCuenta
        {
            get
            {
                return tipoCuenta;
            }
            set
            {
                tipoCuenta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public virtual ContextCuenta contextCuenta
        {
            get;
            set;
        }

        public virtual ICuenta ICuenta
        {
            get;
            set;
        }

        public Cuenta()
        {
            nombre = null;
            tipoCuenta = 0;
            monto = 0;
            periodo = 0;
            moneda = 0;
        }

        public Cuenta(string nombre, TipoCuenta tipoCuenta, float monto, int periodo, Moneda moneda)
        {
            this.nombre = nombre;
            this.tipoCuenta = tipoCuenta;
            this.monto = monto;
            this.periodo = periodo;
            this.moneda = moneda;
            this.interesAnual = 0;
            this.interesGanado = 0;
        }

        public virtual float calcularTotal()
        {
            throw new System.NotImplementedException();
        }

        public virtual float calcularRetencion(float interesAnual, float monto)
        {
            throw new System.NotImplementedException();
        }

        public virtual float obtenerInteresAnual()
        {
            throw new System.NotImplementedException();
        }

        public virtual float calcularInteresGanado()
        {
            throw new System.NotImplementedException();
        }

        public String toString()
        {
            String infoCuenta;
            infoCuenta = "--- Datos del cliente y su operación bancaria ---" + '\n' + "Cliente " + nombre + '\n' +
                "Monto de ahorro e inversión: " + monto + '\n' + "Plazo de la inversión días: " + periodo + '\n' +
                "Sistema de ahorro e inversión: " + tipoCuenta.ToString() + '\n' + "Interés anual correspondiente: " +
                interesAnual + '\n' + "Rendimiento" + '\n' + "Plazo en días: " + periodo + '\n' +
                "Monto de ahorro e inversión: " + monto + '\n' + "Intereses Ganados: " + interesGanado + '\n' +
                "Saldo Final: " + calcularTotal();
            return infoCuenta;
        }

    }
}

