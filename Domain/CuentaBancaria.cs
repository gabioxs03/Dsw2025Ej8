namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public abstract TipoCuenta Tipo { get; }
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; protected set; }
    public string[] Titulares { get; }

    public CuentaBancaria(string numero, string[] titulares, decimal saldo)
    {
        Numero = numero;
        Saldo = saldo;
        Estado = Estado.Activa;
        Titulares = titulares;
    }

    public virtual void Depositar(decimal monto)
    {
        Console.WriteLine("Deposito en cuenta bancaria");
    }

    public virtual void Retirar(decimal monto)
    {
        Console.WriteLine("Retiro en cuenta bancaria");
    } 

    public void retiroInvalido()
    {
        Estado = Estado.Suspendida;
        throw new SaldoInsuficienteException();
    }
    public void validarMonto(decimal monto)
    {
        if (monto <= 0)
        {
            throw new MontoNoValidoException();
        }
    }

    public void validarCuentaActiva()
    {
        if (Estado != Estado.Activa)
        {
            throw new CuentaNoActivaException(Estado.ToString());
        }
    }
}
