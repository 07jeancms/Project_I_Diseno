using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ContextCuenta
    {
        private AdministradorOperaciones administradorDeOperaciones;

        public AdministradorOperaciones AdministradorDeOperaciones
        {
            get
            {
                return administradorDeOperaciones;
            }

            set
            {
                this.administradorDeOperaciones = value;
            }
        }

        public ContextCuenta(AdministradorOperaciones pAdministradorDeOperaciones) {
            administradorDeOperaciones = pAdministradorDeOperaciones;
        }
        public ContextCuenta()
        {
        }

        public bool executeStrategyRevisarMin(float pMonto, int pDias, Moneda pMoneda)
        {
            return administradorDeOperaciones.revisarMinimo(pMonto, pDias, pMoneda);
        }

        public Cuenta executeCrearCuenta(String pNombre, TipoCuenta pTipoCuenta, float pMonto, int pPeriodo, Moneda pMoneda) {
            return administradorDeOperaciones.crearCuenta(pNombre, pTipoCuenta, pMonto, pPeriodo, pMoneda);
        }
    }
}
