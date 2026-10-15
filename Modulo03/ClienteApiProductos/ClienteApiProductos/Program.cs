using System.Globalization;
using System.Text.Json;
using ClienteApiProductos.Models;
using ClienteApiProductos.Services;

namespace ClienteApiProductos;

internal static class Program
{
    private const string DireccionApi = "http://localhost:5085/";

    private static readonly JsonSerializerOptions OpcionesJson = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true
    };

    private static async Task Main()
    {
        using HttpClient httpClient = new()
        {
            BaseAddress = new Uri(DireccionApi),
            Timeout = TimeSpan.FromSeconds(10)
        };

        ProductoApiClient api = new(httpClient);

        bool salir = false;

        Console.WriteLine("CLIENTE HTTP - API DE PRODUCTOS");
        Console.WriteLine("================================");

        while (!salir)
        {
            MostrarMenu();

            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine() ?? string.Empty;

            if (opcion == "0")
            {
                salir = true;
                continue;
            }

            try
            {
                await EjecutarOpcionAsync(opcion, api);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR DE CONEXIÓN");
                Console.WriteLine("No se ha podido establecer comunicación con la API.");
                Console.WriteLine(
                    "Comprueba que ApiProductos está ejecutándose y que la dirección configurada es correcta."
                );
                Console.WriteLine(ex.Message);
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine();
                Console.WriteLine("La petición ha excedido el tiempo de espera.");
            }

            if (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("Pulsa una tecla para continuar.");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        Console.WriteLine("Aplicación finalizada.");
    }

    private static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("MENÚ PRINCIPAL");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1. Consultar información de la API");
        Console.WriteLine("2. Comprobar el estado de la API");
        Console.WriteLine("3. Consultar los endpoints disponibles");
        Console.WriteLine("4. Obtener todos los productos");
        Console.WriteLine("5. Obtener un producto por ID");
        Console.WriteLine("6. Filtrar productos por categoría");
        Console.WriteLine("7. Filtrar productos por precio máximo");
        Console.WriteLine("8. Obtener las categorías");
        Console.WriteLine("9. Obtener estadísticas");
        Console.WriteLine("10. POST: crear producto válido");
        Console.WriteLine("11. POST: precio inválido");
        Console.WriteLine("12. POST: varios campos inválidos");
        Console.WriteLine("13. PUT: modificar producto existente");
        Console.WriteLine("14. PUT: producto inexistente");
        Console.WriteLine("15. PUT: datos inválidos");
        Console.WriteLine("16. DELETE: eliminar un producto");
        Console.WriteLine("17. Probar una ruta inexistente");
        Console.WriteLine("18. Filtrar con un precio negativo");
        Console.WriteLine("0. Salir");
        Console.WriteLine("-------------------------------------");
    }

    private static async Task EjecutarOpcionAsync(
        string opcion,
        ProductoApiClient api)
    {
        switch (opcion)
        {
            case "1":
                MostrarResultado(await api.ObtenerInformacionAsync());
                break;

            case "2":
                MostrarResultado(await api.ComprobarEstadoAsync());
                break;

            case "3":
                MostrarResultado(await api.ObtenerAyudaAsync());
                break;

            case "4":
                MostrarResultado(await api.ObtenerProductosAsync());
                break;

            case "5":
                {
                    int id = LeerEntero("Identificador del producto: ");

                    MostrarResultado(
                        await api.ObtenerProductoPorIdAsync(id)
                    );
                    break;
                }

            case "6":
                {
                    Console.Write("Categoría que deseas buscar: ");
                    string categoria = Console.ReadLine() ?? string.Empty;

                    MostrarResultado(
                        await api.ObtenerProductosAsync(categoria: categoria)
                    );
                    break;
                }

            case "7":
                {
                    decimal precioMax = LeerDecimal("Precio máximo: ");

                    MostrarResultado(
                        await api.ObtenerProductosAsync(precioMax: precioMax)
                    );
                    break;
                }

            case "8":
                MostrarResultado(await api.ObtenerCategoriasAsync());
                break;

            case "9":
                MostrarResultado(await api.ObtenerEstadisticasAsync());
                break;

            case "10":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "Sonda de temperatura " + DateTime.Now.ToString("HHmmss"),
                        Descripcion = "Sonda para registrar la temperatura del agua.",
                        Categoria = "Instrumentación",
                        Precio = 149.95m,
                        Stock = 5
                    };

                    Console.WriteLine("Producto que se enviará:");
                    MostrarSolicitud(solicitud);

                    MostrarResultado(
                        await api.CrearProductoAsync(solicitud)
                    );
                    break;
                }

            case "11":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "Producto de prueba",
                        Descripcion = "Prueba de validación del precio.",
                        Categoria = "Pruebas",
                        Precio = 0m,
                        Stock = 5
                    };

                    Console.WriteLine("Se enviará un producto con precio 0.");
                    MostrarSolicitud(solicitud);

                    MostrarResultado(
                        await api.CrearProductoAsync(solicitud)
                    );
                    break;
                }

            case "12":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "",
                        Descripcion = "",
                        Categoria = "",
                        Precio = -10m,
                        Stock = -1
                    };

                    Console.WriteLine(
                        "Se enviará un producto con varios datos inválidos."
                    );
                    MostrarSolicitud(solicitud);

                    MostrarResultado(
                        await api.CrearProductoAsync(solicitud)
                    );
                    break;
                }

            case "13":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "Portátil de exploración actualizado",
                        Descripcion = "Portátil resistente para investigación submarina.",
                        Categoria = "Informática",
                        Precio = 1349.90m,
                        Stock = 7
                    };

                    Console.WriteLine("Se actualizará el producto con ID 1.");

                    MostrarResultado(
                        await api.ActualizarProductoAsync(1, solicitud)
                    );
                    break;
                }

            case "14":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "Producto inexistente",
                        Descripcion = "Prueba de respuesta 404.",
                        Categoria = "Pruebas",
                        Precio = 50m,
                        Stock = 2
                    };

                    MostrarResultado(
                        await api.ActualizarProductoAsync(9999, solicitud)
                    );
                    break;
                }

            case "15":
                {
                    CrearProductoRequest solicitud = new()
                    {
                        Nombre = "Producto inválido",
                        Descripcion = "Prueba de PUT con datos incorrectos.",
                        Categoria = "Pruebas",
                        Precio = 0m,
                        Stock = 2
                    };

                    MostrarResultado(
                        await api.ActualizarProductoAsync(1, solicitud)
                    );
                    break;
                }

            case "16":
                {
                    int id = LeerEntero("ID del producto que deseas eliminar: ");

                    MostrarResultado(
                        await api.EliminarProductoAsync(id)
                    );
                    break;
                }

            case "17":
                MostrarResultado(await api.ProbarRutaInexistenteAsync());
                break;

            case "18":
                MostrarResultado(
                    await api.ObtenerProductosAsync(precioMax: -10m)
                );
                break;

            default:
                Console.WriteLine(
                    "Opción no válida. Selecciona una opción del menú."
                );
                break;
        }
    }

    private static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(entrada, out int valor))
            {
                return valor;
            }

            Console.WriteLine("Introduce un número entero válido.");
        }
    }

    private static decimal LeerDecimal(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine() ?? string.Empty;

            bool valido =
                decimal.TryParse(
                    entrada,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal valor
                )
                ||
                decimal.TryParse(
                    entrada,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out valor
                );

            if (valido)
            {
                return valor;
            }

            Console.WriteLine("Introduce un número decimal válido.");
        }
    }

    private static void MostrarSolicitud(CrearProductoRequest solicitud)
    {
        Console.WriteLine(
            JsonSerializer.Serialize(solicitud, OpcionesJson)
        );
    }

    private static void MostrarResultado<T>(ApiResult<T> resultado)
    {
        Console.WriteLine();
        Console.WriteLine("RESPUESTA HTTP");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine(
            $"Estado: {(int)resultado.StatusCode} {resultado.StatusCode}"
        );

        if (resultado.IsSuccessStatusCode)
        {
            Console.WriteLine("La petición HTTP ha sido satisfactoria.");
        }
        else
        {
            Console.WriteLine("La petición HTTP no ha sido satisfactoria.");

            Console.WriteLine(
                resultado.ErrorMessage ?? "No se ha recibido un mensaje de error."
            );
        }

        object? datos = resultado.Data;

        if (resultado.IsSuccessStatusCode)
        {
            switch (datos)
            {
                case List<Producto> productos:
                    MostrarProductos(productos);
                    break;

                case Producto producto:
                    MostrarProducto(producto);
                    break;

                case List<string> categorias:
                    foreach (string categoria in categorias)
                    {
                        Console.WriteLine("- " + categoria);
                    }

                    if (categorias.Count == 0)
                    {
                        Console.WriteLine("No hay categorías disponibles.");
                    }

                    break;

                case EstadisticasProductos estadisticas:
                    Console.WriteLine(
                        $"Total de productos: {estadisticas.TotalProductos}"
                    );
                    Console.WriteLine(
                        $"Stock total: {estadisticas.StockTotal}"
                    );
                    Console.WriteLine(
                        $"Precio medio: {estadisticas.PrecioMedio:C2}"
                    );
                    Console.WriteLine(
                        $"Precio máximo: {estadisticas.PrecioMaximo:C2}"
                    );
                    Console.WriteLine(
                        $"Precio mínimo: {estadisticas.PrecioMinimo:C2}"
                    );
                    break;

                case JsonElement:
                    MostrarJson(resultado.ResponseBody);
                    break;

                default:
                    if (string.IsNullOrWhiteSpace(resultado.ResponseBody))
                    {
                        Console.WriteLine(
                            "La respuesta no contiene cuerpo. " +
                            "Esto es normal en una respuesta 204 No Content."
                        );
                    }
                    else
                    {
                        MostrarJson(resultado.ResponseBody);
                    }

                    break;
            }
        }
        else if (!string.IsNullOrWhiteSpace(resultado.ResponseBody))
        {
            Console.WriteLine();
            Console.WriteLine("Cuerpo de la respuesta de error:");
            MostrarJson(resultado.ResponseBody);
        }

        Console.WriteLine("-------------------------------------");
    }

    private static void MostrarProductos(List<Producto> productos)
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("La consulta no ha devuelto productos.");
            return;
        }

        foreach (Producto producto in productos)
        {
            Console.WriteLine();
            MostrarProducto(producto);
        }
    }

    private static void MostrarProducto(Producto producto)
    {
        Console.WriteLine($"ID: {producto.Id}");
        Console.WriteLine($"Nombre: {producto.Nombre}");
        Console.WriteLine($"Descripción: {producto.Descripcion}");
        Console.WriteLine($"Categoría: {producto.Categoria}");
        Console.WriteLine($"Precio: {producto.Precio:C2}");
        Console.WriteLine($"Stock: {producto.Stock}");
    }

    private static void MostrarJson(string contenido)
    {
        if (string.IsNullOrWhiteSpace(contenido))
        {
            Console.WriteLine("(Sin contenido)");
            return;
        }

        try
        {
            using JsonDocument documento = JsonDocument.Parse(contenido);

            Console.WriteLine(
                JsonSerializer.Serialize(
                    documento.RootElement,
                    OpcionesJson
                )
            );
        }
        catch (JsonException)
        {
            Console.WriteLine(contenido);
        }
    }
}