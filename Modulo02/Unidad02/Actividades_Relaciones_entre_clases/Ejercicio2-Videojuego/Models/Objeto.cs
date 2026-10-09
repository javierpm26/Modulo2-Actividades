namespace RelacionesEntreClasesVideojuego
{
    public class Objeto
    {
        public string NombreObjeto {get;set;}
        public TipoObjeto TipoObjeto {get;set;}
        public int Cantidad {get;set;}
        public Objeto(string nombreobjeto, TipoObjeto tipoobjeto, int cantidad)
        {
            NombreObjeto = nombreobjeto;
            TipoObjeto = tipoobjeto;
            Cantidad = cantidad;
        }
    }
}