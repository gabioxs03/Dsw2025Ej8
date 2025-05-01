using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaCorriente cc1 = new CuentaCorriente("123456", new string[] { "Bernabe Diaz" }, 100.0m, 0.015m)
            {
                LimiteDeDescubierto = 500
            };
            CajaDeAhorro ca1 = new CajaDeAhorro("654321", new string[] { "Gabriel Samaniego", "Felicitas Ralle" }, 500.0m)
            {
                TasaDeInteres = 0.05m
            };
            CuentaCorriente cc2 = new CuentaCorriente("123457",new string[] {"Francisco Vicente"},999.9m,0.015m)
            {
                LimiteDeDescubierto = 2500
            };
            CajaDeAhorro ca2 = new CajaDeAhorro("654322", new string[] { "Vicente Chivilisco" }, 500.0m)
            {
                TasaDeInteres = 0.05m
            };

            cc1.agregarCuenta();
            ca1.agregarCuenta();
            cc2.agregarCuenta();
            ca2.agregarCuenta();

            //cc1.Depositar(100.0m);
            //cc2.Retirar(10000.0m);

            ca1.Depositar(100.0m);
            ca2.Retirar(1000.0m);

            CuentaBancaria.mostrarResumen();



        }
    }
}
