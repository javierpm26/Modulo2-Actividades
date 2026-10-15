using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteApiProductos.Models
{
    public sealed class EstadisticasProductos
    {
        public int TotalProductos { get; set; }
        public int StockTotal { get; set; }
        public decimal PrecioMedio { get; set; }
        public decimal PrecioMaximo { get; set; }
        public decimal PrecioMinimo { get; set; }
    }
}
