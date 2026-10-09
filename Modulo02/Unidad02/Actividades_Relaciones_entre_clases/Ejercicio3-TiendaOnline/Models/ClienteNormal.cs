namespace RelacionesEntreClasesTiendaOnline
{
    public class ClienteNormal : Cliente
    {
        public ClienteNormal(string nombrecliente, string emailcliente) : base(nombrecliente, emailcliente)
        {
        }

        public override void MostrarBeneficioCliente()
        {
            Console.WriteLine("Este cliente tiene una membresía BASE.");
        }
    }
}