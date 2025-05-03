using Dsw2025Ej8.Data;
using Dsw2025Ej8.View;

namespace Dsw2025Ej8;

internal class Program
{
    static void Main(string[] args)
    {
        Persistencia.InicializarPersistencia();
        Menu.RunMenu();
    }
}
