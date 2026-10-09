namespace RelacionesEntreClasesTiendaOnline
{
    public class ClientePremium : Cliente
    {
        public decimal DescuentoPremium { get; set; }

        public ClientePremium(string nombrecliente, string emailcliente) : base(nombrecliente, emailcliente)
        {
            DescuentoPremium = 10;
        }

        public override void MostrarBeneficioCliente()
        {
            Console.WriteLine("Este cliente tiene una membresía PREMIUM.");
            Console.WriteLine($"Dispone de un descuento del {DescuentoPremium}%.");
        }

        public void CalcularDescuentoPremium(Pedido pedidoCliente)
        {
            decimal precioTotalPedido = 0;

            foreach (LineaPedido lineaTicket in pedidoCliente.LineasPedidos)
            {
                precioTotalPedido = precioTotalPedido + lineaTicket.SubtotalPedido();
            }

            Console.WriteLine(
                $"El precio total de este recibo con el descuento aplicado es de " +
                $"{precioTotalPedido - (precioTotalPedido * (DescuentoPremium / 100))}€"
            );
        }
    }
}