using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2025Ej8.Domain;

public class CuentaCorriente : CuentaBancaria
{
    public override TipoCuenta Tipo => TipoCuenta.CuentaCorriente;
    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; }
    public CuentaCorriente(string numero, string[] titulares, decimal saldo, decimal comision) : base(numero, titulares, saldo)
    {
        Comision = comision;
    }

    public override void Depositar(decimal monto)
    {
        try
        {
            ValidarCuentaActiva();
            ValidarMonto(monto);
            monto -= monto * Comision;
            Saldo += monto;
            Console.WriteLine("Se realizo el deposito exitosamente");
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }

    public override void Retirar(decimal monto)
    {
        try
        {
            ValidarCuentaActiva();
            ValidarMonto(monto);
            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;
            }
            else { RetiroInvalido(); }
            Console.WriteLine("Se realizo el retiro exitosamente");
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}
