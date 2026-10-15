using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ClienteApiProductos
{
    public sealed class ApiResult<T>
    {
        public HttpStatusCode StatusCode { get; init; }
        public string ResponseBody { get; init; } = string.Empty;
        public T? Data { get; init; }
        public string? ErrorMessage { get; init; }
        public bool IsSuccessStatusCode =>
            (int)StatusCode >= 200 &&
            (int)StatusCode <= 299;
    }
}
