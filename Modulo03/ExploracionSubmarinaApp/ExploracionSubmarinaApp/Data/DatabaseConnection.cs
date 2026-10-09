using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace ExploracionSubmarinaApp.Data;

public static class DatabaseConnection
{
    private static readonly IConfigurationRoot Configuracion = 
        new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile(
            "appsettings.json",
            optional: false,
            reloadOnChange: false
            )
        .Build();

    private static readonly string CadenaCodexion =
        Configuracion.GetConnectionString("MySql")
        ?? throw new InvalidOperationException(
            "No se ha encontrado la cadena de conexión MySql."
        );

    public static MySqlConnection CrearConexion()
    {
        return new MySqlConnection(CadenaCodexion);
    }
}
