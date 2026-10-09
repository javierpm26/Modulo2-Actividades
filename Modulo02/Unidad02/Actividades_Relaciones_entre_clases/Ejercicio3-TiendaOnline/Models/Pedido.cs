namespace RelacionesEntreClasesTiendaOnline
{
    public class Pedido
    {
        public int CodigoPedido {get;set;}
        public Cliente ClientePedido {get;set;}
        public List<LineaPedido> LineasPedidos {get;set;}
        public Pedido(int codigopedido, Cliente clientepedido)
        {
            CodigoPedido = codigopedido;
            ClientePedido = clientepedido;
            LineasPedidos = new List<LineaPedido>();
        }

        public void AnadirProductoAPedido(Producto producto, int cantidad)
        {
            LineaPedido partePedido = new LineaPedido(producto, cantidad);
            LineasPedidos.Add(partePedido);
        }

        public void MostrarDetallesPedido()
        {
            decimal totalImporte = 0;

            Console.WriteLine($"El código de este pedido es {CodigoPedido}");
            Console.WriteLine($"El cliente que ha encargado el pedido es {ClientePedido.NombreCliente}");
            Console.WriteLine("El recibo del pedido es el siguiente ");
            
            foreach(LineaPedido item in LineasPedidos)
            {
                Console.WriteLine($"Producto: {item.ProductoPedido.NombreProducto} - Cantidad: x {item.CantidadProducto}");
                totalImporte = totalImporte + (item.ProductoPedido.PrecioProducto * item.CantidadProducto);
            }

            Console.WriteLine($"Total importe: {totalImporte}");
        }
    }
}