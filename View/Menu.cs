using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Data;
using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8.View;

public static class Menu
{
    public static void RunMenu()
    {
        Console.Clear();
        Console.WriteLine("-----------Sistema Bancario-----------");
        Console.WriteLine("1. Depositar");
        Console.WriteLine("2. Retirar");
        Console.WriteLine("3. Listar Resumen Cuentas");
        Console.WriteLine("4. Salir");
        Console.WriteLine("Seleccione una opcion:");
        var opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Ingrese el numero de cuenta:");
                var numero = Console.ReadLine();
                var cuentaEncontrada = false;
                try
                {
                    foreach (var cuenta in Persistencia.Cuentas)
                    {
                        if (cuenta.Numero == numero)
                        {
                            cuentaEncontrada = true;
                            Console.WriteLine("Ingrese el monto a depositar:");
                            var monto = Convert.ToDecimal(Console.ReadLine());
                            cuenta.Depositar(monto);
                        }
                    }
                    if (!cuentaEncontrada) throw new CuentaNoEncontradaException();
                }
                catch(CuentaNoEncontradaException ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
                RunMenu();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Ingrese el numero de cuenta:");
                var numero2 = Console.ReadLine();
                cuentaEncontrada = false;
                try
                {
                    foreach (var cuenta in Persistencia.Cuentas)
                    {
                        if (cuenta.Numero == numero2)
                        {
                            cuentaEncontrada = true;
                            Console.WriteLine("Ingrese el monto a retirar:");
                            var monto2 = Convert.ToDecimal(Console.ReadLine());
                            cuenta.Retirar(monto2);
                        }
                    }
                    if (!cuentaEncontrada) throw new CuentaNoEncontradaException();
                }
                catch (CuentaNoEncontradaException ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
                RunMenu();
                break;
            case 3:
                Console.Clear();
                foreach (var cuenta in Persistencia.Cuentas)
                {
                    var resumen = new
                    {
                        Numero = cuenta.Numero,
                        Titulares = string.Join(", ", cuenta.Titulares),
                        Tipo = cuenta.Tipo.ToString(),
                        Saldo = cuenta.Saldo,
                        Estado = cuenta.Estado,
                    };

                    Console.WriteLine($"Número: {resumen.Numero}, Titulares: {resumen.Titulares}, Tipo: {resumen.Tipo}, Saldo: {resumen.Saldo}, Estado de cuenta: {resumen.Estado}");
                }
                Console.ReadKey();
                RunMenu();
                break;
            case 4:
                Console.WriteLine("Saliendo del sistema...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opcion no valida");
                RunMenu();
                break;
        }
    }
}
