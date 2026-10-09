namespace RelacionesEntreClasesTiendaOnline
{
    public class LineaPedido
    {
        public Producto ProductoPedido {get;set;}
        public int CantidadProducto {get;set;}
        public LineaPedido(Producto productopedido, int cantidadproducto)
        {
            ProductoPedido = productopedido;
            CantidadProducto = cantidadproducto;
        }

        public decimal SubtotalPedido()
        {
            decimal subtotalLineaPedido = this.ProductoPedido.PrecioProducto*this.CantidadProducto;
            Console.WriteLine($"El coste total de esta línea del pedido es {subtotalLineaPedido}");
            return subtotalLineaPedido;
        }
    }
}