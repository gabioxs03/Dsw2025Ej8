using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente cuentaCorriente = new CuentaCorriente("123456",new string[] { "Bernabe Diaz" },100.0m, 50.0m);
            CajaDeAhorro cajaDeAhorro = new CajaDeAhorro("654321",new string[]{"Gabriel Samaniego","Felicitas Ralle"}, 500.0m);

        }
    }
}
