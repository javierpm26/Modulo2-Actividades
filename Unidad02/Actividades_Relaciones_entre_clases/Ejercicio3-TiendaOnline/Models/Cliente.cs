namespace RelacionesEntreClasesTiendaOnline
{
    public class Cliente
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
    }
}