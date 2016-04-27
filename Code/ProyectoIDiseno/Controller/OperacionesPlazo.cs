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
    using ProyectoIDiseno.Controller;
    public class OperacionesPlazo : AdministradorOperaciones
    {
        private static int PLAZO_DIAS = 30;
        private static int PLAZO_Especial1_Inicio = 30;
        private static int PLAZO_Especial1_FIN = 89;
        private static float MONTO_PLAZO_ESPECIAL_1 = 100000;

        private static float MIN_INVERSION = 100000;
        private static float MONTO_PLAZO_ESPECIAL_2 = 50000;

        private static int PLAZO_ESPECIAL2 = 90;

        private CuentaFactory cuentaFactory = new CuentaFactory();

        /*
         *Cuando el plazo pactado se encuentra en el rango de 30 a 89 días, el monto mínimo de inversión debe ser de 100,000 colones. 
        */
        public bool verificarPlazoEspecial1(int pDias) {
            if(pDias >= PLAZO_Especial1_Inicio && pDias <= PLAZO_Especial1_FIN) 
                return true;
            return false;
        }

        public bool verificarPlazoEspecial2(int pDias) {
            if (pDias >= PLAZO_ESPECIAL2)
                return true;
            return false;
        }

        public bool verificarCantidad(float pMonto, float pMontoLimite) {
            return pMonto >= pMontoLimite;
        }

        public Cuenta crearCuenta(String pNombre, TipoCuenta pTipoCuenta, float pMonto, int pPeriodo, Moneda pMoneda)
        {
            return cuentaFactory.getCuenta(pNombre, pTipoCuenta, pMonto, pPeriodo, pMoneda);
        }

        public virtual bool revisarMinimo(float pMonto, int pDias, Moneda pMoneda)
        {
            if (pMoneda == Moneda.Colon) {
                if (pDias >= PLAZO_DIAS) {
                    if (verificarPlazoEspecial1(pDias)) { 
                        if (verificarCantidad(pMonto, MONTO_PLAZO_ESPECIAL_1))
                            return true;
                        else {
                            Console.WriteLine("ERROR: Se necesita un monto mayor o igual a " + MONTO_PLAZO_ESPECIAL_1);
                            return false;
                        }
                    }
                    if (verificarPlazoEspecial2(pDias)) {
                        if (verificarCantidad(pMonto, MONTO_PLAZO_ESPECIAL_2))
                            return true;
                        else
                        {
                            Console.WriteLine("ERROR: Se necesita un monto mayor o igual " + MONTO_PLAZO_ESPECIAL_2);
                            return false;
                        }
                    }
                    return false;
                }
                else {
                    Console.WriteLine("ERROR: Los certificados a largo plazo solo aplican para un minimo de " + PLAZO_DIAS + " dias");
                    return false;
                }
            }
            else {
                Console.WriteLine("ERROR: Los certificados a largo plazo solo aplican para colones");
                return false; 
            }
        }

        public Cuenta crearCuenta(TipoCuenta pTipo)
        {
            throw new NotImplementedException();
        }

        public bool revisarMinimo(string pNombre, TipoCuenta pTipoCuenta, float pMonto, int pPeriodo, Moneda pMoneda)
        {
            throw new NotImplementedException();
        }
    }
}

