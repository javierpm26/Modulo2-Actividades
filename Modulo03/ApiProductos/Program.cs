using System.ComponentModel.DataAnnotations;
using ApiProductos.Models;
using ApiProductos.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ProductoStore>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Devuelve respuestas estructuradas ante errores inesperados.
app.UseExceptionHandler();

app.MapGet("/", () => Results.Ok(new
{
    nombre = "API de Productos",
    version = "1.0",
    descripcion = "API de ejemplo para practicar HttpClient, GET, POST y JSON.",
    documentacion = "Consulta los endpoints disponibles en /api/ayuda."
}));

app.MapGet("/api/health", () => Results.Ok(new
{
    estado = "correcto",
    fecha = DateTimeOffset.UtcNow
}));

app.MapGet("/api/ayuda", () => Results.Ok(new
{
    endpoints = new[]
    {
        new { metodo = "GET", ruta = "/api/productos", descripcion = "Lista productos; filtros opcionales categoria y precioMax." },
        new { metodo = "GET", ruta = "/api/productos/{id}", descripcion = "Obtiene un producto por identificador." },
        new { metodo = "GET", ruta = "/api/productos/estadisticas", descripcion = "Devuelve estadísticas globales." },
        new { metodo = "GET", ruta = "/api/categorias", descripcion = "Lista las categorías disponibles." },
        new { metodo = "POST", ruta = "/api/productos", descripcion = "Crea un producto a partir de un cuerpo JSON." },
        new { metodo = "PUT", ruta = "/api/productos/{id}", descripcion = "Reemplaza los datos de un producto existente." },
        new { metodo = "DELETE", ruta = "/api/productos/{id}", descripcion = "Elimina un producto." }
    }
}));

// GET: lista todos los productos o aplica filtros opcionales.
app.MapGet("/api/productos", (
    string? categoria,
    decimal? precioMax,
    ProductoStore store) =>
{
    if (precioMax is < 0)
    {
        return Results.BadRequest(new
        {
            mensaje = "El parámetro precioMax no puede ser negativo."
        });
    }

    return Results.Ok(store.ObtenerTodos(categoria, precioMax));
});

// GET: estadísticas de todos los productos.
app.MapGet("/api/productos/estadisticas", (ProductoStore store) =>
{
    IReadOnlyList<Producto> productos = store.ObtenerTodos();

    return Results.Ok(new
    {
        totalProductos = productos.Count,
        stockTotal = productos.Sum(p => p.Stock),
        precioMedio = productos.Count == 0 ? 0 : Math.Round(productos.Average(p => p.Precio), 2),
        precioMaximo = productos.Count == 0 ? 0 : productos.Max(p => p.Precio),
        precioMinimo = productos.Count == 0 ? 0 : productos.Min(p => p.Precio)
    });
});

// GET: obtiene un producto por ID; 404 si no existe.
app.MapGet("/api/productos/{id:int}", (int id, ProductoStore store) =>
{
    Producto? producto = store.ObtenerPorId(id);

    return producto is null
        ? Results.NotFound(new { mensaje = $"No existe un producto con ID {id}." })
        : Results.Ok(producto);
})
.WithName("ObtenerProductoPorId");

app.MapGet("/api/categorias", (ProductoStore store) =>
    Results.Ok(store.ObtenerCategorias()));

// POST: valida los datos y crea un producto. La API genera su identificador.
app.MapPost("/api/productos", (CrearProductoRequest solicitud, ProductoStore store) =>
{
    Dictionary<string, string[]> errores = ValidarModelo(solicitud);

    if (errores.Count > 0)
    {
        return Results.ValidationProblem(errores);
    }

    Producto producto = store.Crear(solicitud);

    return Results.Created($"/api/productos/{producto.Id}", producto);
});

// PUT: actualiza todos los campos editables de un producto existente.
app.MapPut("/api/productos/{id:int}", (int id, CrearProductoRequest solicitud, ProductoStore store) =>
{
    Dictionary<string, string[]> errores = ValidarModelo(solicitud);

    if (errores.Count > 0)
    {
        return Results.ValidationProblem(errores);
    }

    Producto? actualizado = store.Actualizar(id, solicitud);

    return actualizado is null
        ? Results.NotFound(new { mensaje = $"No existe un producto con ID {id}." })
        : Results.Ok(actualizado);
});

// DELETE: elimina el producto o devuelve 404 si no existe.
app.MapDelete("/api/productos/{id:int}", (int id, ProductoStore store) =>
{
    bool eliminado = store.Eliminar(id);

    return eliminado
        ? Results.NoContent()
        : Results.NotFound(new { mensaje = $"No existe un producto con ID {id}." });
});

// Escucha en todas las interfaces IPv4 para poder utilizarse desde otros equipos de la LAN.
// En un aula, usar solo una red local de confianza y no publicar este puerto en Internet.
app.Run("http://0.0.0.0:5085");

static Dictionary<string, string[]> ValidarModelo<T>(T modelo)
{
    List<ValidationResult> resultados = new();
    ValidationContext contexto = new(modelo!);

    Validator.TryValidateObject(modelo!, contexto, resultados, validateAllProperties: true);

    return resultados
        .SelectMany(resultado =>
        {
            string[] miembros = resultado.MemberNames.Any()
                ? resultado.MemberNames.ToArray()
                : ["solicitud"];

            return miembros.Select(miembro => new
            {
                Miembro = miembro,
                Mensaje = resultado.ErrorMessage ?? "El valor no es válido."
            });
        })
        .GroupBy(error => error.Miembro)
        .ToDictionary(
            grupo => grupo.Key,
            grupo => grupo.Select(error => error.Mensaje).ToArray()
        );
}
