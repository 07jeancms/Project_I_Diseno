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

    public interface AdministradorOperaciones
    {

		Cuenta crearCuenta(String pNombre, TipoCuenta pTipoCuenta, float pMonto, int pPeriodo, Moneda pMoneda);
     
		bool revisarMinimo(float pMonto, int pDias, Moneda pMoneda);
	}
}

