using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {
        public override TipoCuenta Tipo => TipoCuenta.CuentaCorriente;
        public decimal LimiteDeDescubierto { get; protected set; }
        private decimal Comision { get; set; }
        public CuentaCorriente(string numero, string[] titulares, decimal saldo, decimal comision) : base(numero, titulares, saldo)
        {
            Comision = comision;
        }

        #region getter/setter
        //public decimal GetLimiteDeDescubierto()
        //{
        //    return _limiteDeDescubierto;
        //}
        //public void SetLimiteDeDescubierto(decimal limiteDeDescubierto)
        //{
        //    _limiteDeDescubierto = limiteDeDescubierto;
        //}
        #endregion

        public override void Depositar(decimal monto)
        {
            validarCuentaActiva();
            validarMonto(monto);
            monto -= monto * Comision;
            Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            validarCuentaActiva();
            validarMonto(monto);
            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;
            }
            else { retiroInvalido(); }
        }
    }
}
