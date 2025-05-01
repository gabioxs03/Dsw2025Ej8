using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public class MontoNoValido : Exception
{
    public MontoNoValido(string message) : base(message)
    {
    }
}

public class CuentaNoActiva : Exception
{ 
    public CuentaNoActiva(string message) : base(message)
    {
    }
}

public class SaldoInsuficiente : Exception
{
    public SaldoInsuficiente(string message) : base(message)
    {
    }
}
