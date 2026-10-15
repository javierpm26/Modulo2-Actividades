# API de Productos (.NET 10)

API REST didáctica para practicar `HttpClient`, GET, POST, JSON, códigos de estado HTTP y manejo de errores. Incluye también PUT y DELETE para ampliaciones posteriores.

## Requisitos

- .NET 10 SDK
- Visual Studio 2022 actualizado para trabajar con .NET 10, o el SDK de .NET 10 instalado
- No necesita MySQL ni paquetes NuGet de terceros

## Ejecutar en Visual Studio

1. Abrir `ApiProductos.csproj`.
2. Seleccionar el proyecto como proyecto de inicio.
3. Ejecutar con F5.
4. La API escucha en `http://localhost:5085`.

También se puede ejecutar desde una terminal en esta carpeta:

```bash
dotnet run
```

## Endpoints principales

| Método | Ruta | Resultado habitual |
|---|---|---|
| GET | `/` | 200 OK: información de la API |
| GET | `/api/health` | 200 OK: estado |
| GET | `/api/ayuda` | 200 OK: lista de rutas |
| GET | `/api/productos` | 200 OK: lista de productos |
| GET | `/api/productos/{id}` | 200 OK o 404 Not Found |
| GET | `/api/productos?categoria=Instrumentación` | 200 OK: filtro por categoría |
| GET | `/api/productos?precioMax=200` | 200 OK: filtro por precio |
| GET | `/api/productos/estadisticas` | 200 OK: estadísticas |
| GET | `/api/categorias` | 200 OK: categorías |
| POST | `/api/productos` | 201 Created o 400 Bad Request |
| PUT | `/api/productos/{id}` | 200 OK, 400 Bad Request o 404 Not Found |
| DELETE | `/api/productos/{id}` | 204 No Content o 404 Not Found |

## Probar peticiones

Abrir `ApiProductos.http` en Visual Studio y utilizar el enlace `Send Request` sobre cada bloque de petición.

## Ejemplo de JSON para POST

```json
{
  "nombre": "Sonda de temperatura",
  "descripcion": "Sonda para registrar la temperatura del agua.",
  "categoria": "Instrumentación",
  "precio": 149.95,
  "stock": 5
}
```

La API valida los datos, genera el ID y responde con `201 Created`, la URL del nuevo recurso en la cabecera `Location` y el producto creado en el cuerpo JSON.

## Datos en memoria

La API almacena los productos en memoria. Los cambios realizados mediante POST, PUT y DELETE duran hasta que se reinicie el proceso. Al reiniciarse, vuelve a cargar los seis productos de ejemplo.

## Uso en el aula / red local

La API escucha en `0.0.0.0:5085` para que pueda accederse desde otros equipos de una red local de confianza. En el mismo equipo se utiliza `http://localhost:5085`. Desde otro equipo se utilizará `http://IP_DEL_EQUIPO_DEL_PROFESOR:5085` y puede ser necesario permitir el puerto TCP 5085 en el Firewall de Windows.

Esta API está diseñada para prácticas en una red local de confianza. No está pensada para exponerse directamente a Internet ni incluye autenticación.
