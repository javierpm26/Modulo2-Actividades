namespace RelacionesEntreClasesTiendaOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 3 - TIENDA ONLINE

            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // Productos
            Producto productoTeclado = new Producto(
                "Teclado mecánico",
                59.99m
            );

            Producto productoRaton = new Producto(
                "Ratón gaming",
                29.95m
            );

            Producto productoMonitor = new Producto(
                "Monitor 24 pulgadas",
                149.90m
            );

            Producto productoAuriculares = new Producto(
                "Auriculares",
                39.50m
            );


            // Clientes
            ClienteNormal clienteAna = new ClienteNormal(
                "Ana",
                "ana@gmail.com"
            );

            ClientePremium clienteCarlos = new ClientePremium(
                "Carlos",
                "carlos@gmail.com"
            );


            // Pedidos
            Pedido pedidoAna1 = new Pedido(
                1001,
                clienteAna
            );

            Pedido pedidoAna2 = new Pedido(
                1002,
                clienteAna
            );

            Pedido pedidoCarlos = new Pedido(
                1003,
                clienteCarlos
            );


            // Añadir productos al primer pedido de Ana
            pedidoAna1.AnadirProductoAPedido(
                productoTeclado,
                1
            );

            pedidoAna1.AnadirProductoAPedido(
                productoRaton,
                2
            );


            // Añadir productos al segundo pedido de Ana
            pedidoAna2.AnadirProductoAPedido(
                productoAuriculares,
                1
            );


            // Añadir productos al pedido de Carlos
            pedidoCarlos.AnadirProductoAPedido(
                productoMonitor,
                1
            );

            pedidoCarlos.AnadirProductoAPedido(
                productoAuriculares,
                2
            );


            // Añadir pedidos a los clientes
            clienteAna.AnadirPedidoACliente(
                pedidoAna1
            );

            clienteAna.AnadirPedidoACliente(
                pedidoAna2
            );

            clienteCarlos.AnadirPedidoACliente(
                pedidoCarlos
            );


            Console.WriteLine();
            Console.WriteLine("DATOS DE CLIENTES");
            Console.WriteLine("======================================");
            Console.WriteLine();

            clienteAna.MostrarInformacionCliente();

            Console.WriteLine();
            clienteAna.MostrarBeneficioCliente();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            clienteCarlos.MostrarInformacionCliente();

            Console.WriteLine();
            clienteCarlos.MostrarBeneficioCliente();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DETALLES DE PEDIDOS");
            Console.WriteLine("======================================");
            Console.WriteLine();

            pedidoAna1.MostrarDetallesPedido();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            pedidoAna2.MostrarDetallesPedido();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            pedidoCarlos.MostrarDetallesPedido();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DESCUENTO DE MEMBRESÍA PREMIUM");
            Console.WriteLine("======================================");
            Console.WriteLine();

            clienteCarlos.CalcularDescuentoPremium(
                pedidoCarlos
            );

            Console.WriteLine();
        }
    }
}