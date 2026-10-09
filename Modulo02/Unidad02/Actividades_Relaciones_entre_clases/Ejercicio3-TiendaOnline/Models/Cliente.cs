namespace RelacionesEntreClasesTiendaOnline
{
    public abstract class Cliente
    {
        public string NombreCliente {get;set;}
        public string EmailCliente {get;set;}
        public List<Pedido> PedidosCliente {get;set;}

        public Cliente(string nombrecliente, string emailcliente)
        {
            NombreCliente = nombrecliente;
            EmailCliente = emailcliente;
            PedidosCliente = new List<Pedido>();
        }

        public void AnadirPedidoACliente(Pedido pedido)
        {
            PedidosCliente.Add(pedido);
        }

        public void MostrarInformacionCliente()
        {
            Console.WriteLine($"El nombre del cliente es {NombreCliente}");
            Console.WriteLine($"Su email de contacto registrado es {EmailCliente}");
            Console.WriteLine("Los productos que ha pedido a través de nuestra tienda son: ");
            
            foreach (Pedido pedido in PedidosCliente)
            {
                Console.WriteLine($"Identificador pedido: {pedido.CodigoPedido}");
                Console.WriteLine($"--------------------");
                
                foreach(LineaPedido registropedido in pedido.LineasPedidos)
                {
                    Console.WriteLine($"Tipo producto: {registropedido.ProductoPedido.NombreProducto}");
                    Console.WriteLine($"Cantidad: {registropedido.CantidadProducto}");
                }
            }
        }
        
        public abstract void MostrarBeneficioCliente();
    }
}