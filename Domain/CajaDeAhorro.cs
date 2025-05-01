using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CajaDeAhorro : CuentaBancaria
    {
        public override TipoCuenta Tipo => TipoCuenta.CajaDeAhorro; 
        public decimal TasaDeInteres { get; init; } 
        public CajaDeAhorro(string numero, string[] titulares, decimal saldo) : base(numero, titulares, saldo) {}
        public override void Depositar(decimal monto)
        {
            validarCuentaActiva();
            validarMonto(monto);
            Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            validarCuentaActiva(); 
            validarMonto(monto);
            if (monto < Saldo) { Saldo -= monto; }
            else { retiroInvalido(); }
        }

        
        public void AplicarInteres()
        {
            validarCuentaActiva();
            Saldo += Saldo * TasaDeInteres;
        }
    }
}
