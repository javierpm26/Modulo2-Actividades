namespace RelacionesEntreClasesTiendaOnline
{
    public class Producto
    {
        public string NombreProducto {get;set;}
        public decimal PrecioProducto {get;set;}
        public Producto(string nombreproducto, decimal precioproducto)
        {
            NombreProducto = nombreproducto;
            PrecioProducto = precioproducto;
        }
    }
}