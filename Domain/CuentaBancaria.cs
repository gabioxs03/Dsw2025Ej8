namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public abstract TipoCuenta Tipo { get; }//este solo tiene getter, es solo lectura
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; protected set; }
    public string[] Titulares { get; }
    public CuentaBancaria(string numero, string[] titulares, decimal saldo)
    {
        Numero = numero;
        Saldo = saldo;
        // _tipo = tipo; //esto esta ok. Si lo descomentas, agregalo en los parametros del constructor (TipoCuenta tipo,)
        Estado = Estado.Activa;
        Titulares = titulares;
    }
    #region Getters/Setters
    //public string GetNumero()
    //{
    //    return _numero;
    //}

    //public decimal GetSaldo()
    //{
    //    return _saldo;
    //}
    //public TipoCuenta GetTipo()
    //{
    //    return _tipo;
    //}

    //public Estado GetEstado()
    //{
    //    return _estado;
    //}

    //public void SetEstado(Estado estado)
    //{
    //    _estado = estado;
    //}

    //public decimal GetComision()
    //{
    //    return _comision;
    //}

    //public void SetComision(decimal comision)
    //{
    //    _comision = comision;
    //}

    //public string[] GetTitulares()
    //{
    //    return _titulares;
    //}
    #endregion

    public void validarMonto(decimal monto)
    {
        if (monto <= 0)
        {
            throw new ArgumentException("El monto ingresado no es válido para la operación solicitada.");
        }
    }

    public void validarCuentaActiva()
    {
        if (Estado != Estado.Activa)
        {
            throw new InvalidOperationException($"No se puede operar con la cuenta {Estado}.");
        }
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
        throw new InvalidOperationException("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
    }

    private static List<CuentaBancaria> cuentas = new();

    public void agregarCuenta()
    {
        cuentas.Add(this);
    }
    public static void mostrarResumen()
    {

        foreach (var cuenta in cuentas)
        {
            var resumen = new { Numero = cuenta.Numero, Tipo = cuenta.Tipo, Saldo = cuenta.Saldo };

            Console.WriteLine($"Cuenta {resumen.Numero} - Tipo: {resumen.Tipo} - Saldo: $ {resumen.Saldo}");
        }
    }
}
