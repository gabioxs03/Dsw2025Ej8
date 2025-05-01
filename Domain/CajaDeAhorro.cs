using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public class CajaDeAhorro : CuentaBancaria
{
    public override TipoCuenta Tipo => TipoCuenta.CajaDeAhorro; 
    public decimal TasaDeInteres { get; init; } 
    public CajaDeAhorro(string numero, string[] titulares, decimal saldo) : base(numero, titulares, saldo) {}
    public override void Depositar(decimal monto)
    {
        try
        {
            validarCuentaActiva();
            validarMonto(monto);
            Saldo += monto;
            Console.WriteLine("Se realizo el deposito exitosamente");
        }
        catch (MontoNoValido ex) { Console.WriteLine($"{ex.Message}"); }
        catch (CuentaNoActiva ex) { Console.WriteLine($"{ex.Message}"); }
    }

    public override void Retirar(decimal monto)
    {
        try
        {
            validarCuentaActiva();
            validarMonto(monto);
            if (monto < Saldo) { Saldo -= monto; }
            else { retiroInvalido(); }
            Console.WriteLine("Se realizo el retiro exitosamente");
        }
        catch (MontoNoValido ex) { Console.WriteLine($"{ex.Message}"); }
        catch (CuentaNoActiva ex) { Console.WriteLine($"{ex.Message}"); }
        catch (SaldoInsuficiente ex) { Console.WriteLine($"{ex.Message}"); }
    }

    
    public void AplicarInteres()
    {
        validarCuentaActiva();
        Saldo += Saldo * TasaDeInteres;
    }
}
