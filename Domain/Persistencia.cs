using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public static class Persistencia
{
    public static List<CuentaBancaria> Cuentas {  get; } = new List<CuentaBancaria>();

    public static void InicializarPersistencia()
    {
        Cuentas.Add(new CuentaCorriente("1", new[] { "Bernabe Diaz" , "Gabriel Samaniego"}, 10000.0M, 0.02M) { LimiteDeDescubierto = 1000 });

        Cuentas.Add(new CajaDeAhorro("2", new[] { "Gabriel Samaniego", "Felicitas Ralle" }, 50000.0M) { TasaDeInteres = 0.05M });

        Cuentas.Add(new CuentaCorriente("3", new[] { "Felicitas Ralle", "Gabriel Samaniego" }, 20000.0M, 0.02M) { LimiteDeDescubierto = 1000 });

        Cuentas.Add(new CajaDeAhorro("4", new[] { "Bernabe Diaz", "Felicitas Ralle" }, 70000.0M) { TasaDeInteres = 0.05M });
    }


}
