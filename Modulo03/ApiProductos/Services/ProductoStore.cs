using System.Collections.Concurrent;
using ApiProductos.Models;

namespace ApiProductos.Services;

/// <summary>
/// Almacén temporal en memoria para la práctica. Los datos se reinician al detener la API.
/// ConcurrentDictionary permite atender peticiones simultáneas de forma segura.
/// </summary>
public sealed class ProductoStore
{
    private readonly ConcurrentDictionary<int, Producto> _productos = new();
    private int _ultimoId;

    public ProductoStore()
    {
        Producto[] iniciales =
        [
            new Producto
            {
                Id = 1,
                Nombre = "Portátil de exploración",
                Descripcion = "Ordenador resistente para el equipo de investigación.",
                Categoria = "Informática",
                Precio = 1299.90m,
                Stock = 8
            },
            new Producto
            {
                Id = 2,
                Nombre = "Tableta rugerizada",
                Descripcion = "Tableta para registrar datos en expediciones.",
                Categoria = "Informática",
                Precio = 649.50m,
                Stock = 12
            },
            new Producto
            {
                Id = 3,
                Nombre = "Sensor de presión",
                Descripcion = "Sensor para medir presión bajo el agua.",
                Categoria = "Instrumentación",
                Precio = 189.95m,
                Stock = 24
            },
            new Producto
            {
                Id = 4,
                Nombre = "Cámara submarina",
                Descripcion = "Cámara estanca para documentación visual.",
                Categoria = "Fotografía",
                Precio = 429.00m,
                Stock = 6
            },
            new Producto
            {
                Id = 5,
                Nombre = "Baliza acústica",
                Descripcion = "Baliza de localización para equipos submarinos.",
                Categoria = "Instrumentación",
                Precio = 315.75m,
                Stock = 0
            },
            new Producto
            {
                Id = 6,
                Nombre = "Batería de larga duración",
                Descripcion = "Batería auxiliar para equipos de medición.",
                Categoria = "Accesorios",
                Precio = 94.90m,
                Stock = 32
            }
        ];

        foreach (Producto producto in iniciales)
        {
            _productos[producto.Id] = producto;
        }

        _ultimoId = iniciales.Max(p => p.Id);
    }

    public IReadOnlyList<Producto> ObtenerTodos(string? categoria = null, decimal? precioMax = null)
    {
        IEnumerable<Producto> consulta = _productos.Values;

        if (!string.IsNullOrWhiteSpace(categoria))
        {
            consulta = consulta.Where(p =>
                string.Equals(p.Categoria, categoria.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        if (precioMax.HasValue)
        {
            consulta = consulta.Where(p => p.Precio <= precioMax.Value);
        }

        return consulta.OrderBy(p => p.Id).ToArray();
    }

    public Producto? ObtenerPorId(int id)
    {
        return _productos.TryGetValue(id, out Producto? producto)
            ? producto
            : null;
    }

    public IReadOnlyList<string> ObtenerCategorias()
    {
        return _productos.Values
            .Select(p => p.Categoria)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(c => c)
            .ToArray();
    }

    public Producto Crear(CrearProductoRequest solicitud)
    {
        int id = Interlocked.Increment(ref _ultimoId);

        Producto producto = new()
        {
            Id = id,
            Nombre = solicitud.Nombre.Trim(),
            Descripcion = solicitud.Descripcion?.Trim() ?? string.Empty,
            Categoria = solicitud.Categoria.Trim(),
            Precio = solicitud.Precio,
            Stock = solicitud.Stock
        };

        _productos[id] = producto;
        return producto;
    }

    public Producto? Actualizar(int id, CrearProductoRequest solicitud)
    {
        while (_productos.TryGetValue(id, out Producto? actual))
        {
            Producto actualizado = new()
            {
                Id = id,
                Nombre = solicitud.Nombre.Trim(),
                Descripcion = solicitud.Descripcion?.Trim() ?? string.Empty,
                Categoria = solicitud.Categoria.Trim(),
                Precio = solicitud.Precio,
                Stock = solicitud.Stock
            };

            if (_productos.TryUpdate(id, actualizado, actual))
            {
                return actualizado;
            }
        }

        return null;
    }

    public bool Eliminar(int id)
    {
        return _productos.TryRemove(id, out _);
    }
}
