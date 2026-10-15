using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using ClienteApiProductos.Models;

namespace ClienteApiProductos.Services
{
    public sealed class ProductoApiClient
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions OpcionesJson =
            new(JsonSerializerDefaults.Web)
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

        public ProductoApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ApiResult<JsonElement>> ObtenerInformacionAsync()
        {
            return GetAsync<JsonElement>("/");
        }

        public Task<ApiResult<JsonElement>> ComprobarEstadoAsync()
        {
            return GetAsync<JsonElement>("api/health");
        }

        public Task<ApiResult<JsonElement>> ObtenerAyudaAsync()
        {
            return GetAsync<JsonElement>("api/ayuda");
        }

        public Task<ApiResult<List<Producto>>> ObtenerProductosAsync(
            string? categoria = null,
            decimal? precioMax = null)
        {
            List<string> parametros = new();

            if (!string.IsNullOrWhiteSpace(categoria))
            {
                parametros.Add(
                    "categoria=" + Uri.EscapeDataString(categoria.Trim())
                );
            }

            if (precioMax.HasValue)
            {
                string precio = precioMax.Value.ToString(
                    CultureInfo.InvariantCulture
                );

                parametros.Add("precioMax=" + precio);
            }

            string ruta = "api/productos";

            if (parametros.Count > 0)
            {
                ruta += "?" + string.Join("&", parametros);
            }

            return GetAsync<List<Producto>>(ruta);
        }

        public Task<ApiResult<Producto>> ObtenerProductoPorIdAsync(int id)
        {
            return GetAsync<Producto>($"api/productos/{id}");
        }

        public Task<ApiResult<List<string>>> ObtenerCategoriasAsync()
        {
            return GetAsync<List<string>>("api/categorias");
        }

        public Task<ApiResult<EstadisticasProductos>> ObtenerEstadisticasAsync()
        {
            return GetAsync<EstadisticasProductos>(
                "api/productos/estadisticas"
            );
        }

        public async Task<ApiResult<Producto>> CrearProductoAsync(
            CrearProductoRequest solicitud)
        {
            string json = JsonSerializer.Serialize(
                solicitud,
                OpcionesJson
            );

            using var contenido = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            using var peticion = new HttpRequestMessage(
                HttpMethod.Post,
                "api/productos")
            {
                Content = contenido
            };

            return await EnviarAsync<Producto>(peticion);
        }

        public async Task<ApiResult<Producto>> ActualizarProductoAsync(
            int id,
            CrearProductoRequest solicitud)
        {
            string json = JsonSerializer.Serialize(
                solicitud,
                OpcionesJson
            );

            using var contenido = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            using var peticion = new HttpRequestMessage(
                HttpMethod.Put,
                $"api/productos/{id}")
            {
                Content = contenido
            };

            return await EnviarAsync<Producto>(peticion);
        }

        public Task<ApiResult<JsonElement>> EliminarProductoAsync(int id)
        {
            HttpRequestMessage peticion = new(
                HttpMethod.Delete,
                $"api/productos/{id}"
            );

            return EnviarAsync<JsonElement>(peticion);
        }

        public Task<ApiResult<JsonElement>> ProbarRutaInexistenteAsync()
        {
            return GetAsync<JsonElement>("api/ruta-inexistente");
        }

        private async Task<ApiResult<T>> GetAsync<T>(string ruta)
        {
            using var peticion = new HttpRequestMessage(
                HttpMethod.Get,
                ruta
            );

            return await EnviarAsync<T>(peticion);
        }

        private async Task<ApiResult<T>> EnviarAsync<T>(
            HttpRequestMessage peticion)
        {
            using (peticion)
            using (HttpResponseMessage respuesta =
                await _httpClient.SendAsync(peticion))
            {
                string contenido =
                    await respuesta.Content.ReadAsStringAsync();

                T? datos = default;
                string? error = null;

                if (respuesta.IsSuccessStatusCode)
                {
                    if (!string.IsNullOrWhiteSpace(contenido))
                    {
                        try
                        {
                            datos = JsonSerializer.Deserialize<T>(
                                contenido,
                                OpcionesJson
                            );
                        }
                        catch (JsonException)
                        {
                            error =
                                "El servidor respondió, pero el contenido " +
                                "no tiene el formato JSON esperado.";
                        }
                    }
                }
                else
                {
                    error = ExtraerMensajeError(contenido);
                }

                return new ApiResult<T>
                {
                    StatusCode = respuesta.StatusCode,
                    ResponseBody = contenido,
                    Data = datos,
                    ErrorMessage = error
                };
            }
        }

        private static string ExtraerMensajeError(string contenido)
        {
            if (string.IsNullOrWhiteSpace(contenido))
            {
                return "El servidor no ha devuelto un mensaje de error.";
            }

            try
            {
                using JsonDocument documento =
                    JsonDocument.Parse(contenido);

                JsonElement raiz = documento.RootElement;

                if (raiz.ValueKind == JsonValueKind.Object)
                {
                    if (raiz.TryGetProperty(
                            "errors",
                            out JsonElement errores) &&
                        errores.ValueKind == JsonValueKind.Object)
                    {
                        List<string> mensajes = new();

                        foreach (JsonProperty propiedad in
                            errores.EnumerateObject())
                        {
                            if (propiedad.Value.ValueKind ==
                                JsonValueKind.Array)
                            {
                                foreach (JsonElement elemento in
                                    propiedad.Value.EnumerateArray())
                                {
                                    if (elemento.ValueKind ==
                                        JsonValueKind.String)
                                    {
                                        mensajes.Add(
                                            propiedad.Name + ": " +
                                            elemento.GetString()
                                        );
                                    }
                                }
                            }
                        }

                        if (mensajes.Count > 0)
                        {
                            return string.Join(
                                Environment.NewLine,
                                mensajes
                            );
                        }
                    }

                    foreach (string nombre in new[]
                    {
                        "mensaje",
                        "title",
                        "detail"
                    })
                    {
                        if (raiz.TryGetProperty(
                                nombre,
                                out JsonElement valor) &&
                            valor.ValueKind == JsonValueKind.String)
                        {
                            return valor.GetString()
                                ?? "La petición no se ha completado.";
                        }
                    }
                }
            }
            catch (JsonException)
            {
                return contenido;
            }

            return contenido;
        }
    }
}