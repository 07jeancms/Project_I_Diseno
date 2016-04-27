using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIDiseno.Controller
{
    public class CuentaFactory
    {
        public Cuenta getCuenta(String pNombre, TipoCuenta pTipoCuenta, float pMonto, int pPeriodo, Moneda pMoneda) {
            if (pTipoCuenta == TipoCuenta.Corriente)
                return new CuentaCorriente(pNombre, pTipoCuenta, pMonto, pPeriodo, pMoneda);
            if (pTipoCuenta == TipoCuenta.Pactada)
                return new CuentaPactado(pNombre, pTipoCuenta, pMonto, pPeriodo, pMoneda);
            if (pTipoCuenta == TipoCuenta.Plazo)
                return new CuentaPlazo(pNombre, pTipoCuenta, pMonto, pPeriodo, pMoneda);
            return null;
        }
    }
}
