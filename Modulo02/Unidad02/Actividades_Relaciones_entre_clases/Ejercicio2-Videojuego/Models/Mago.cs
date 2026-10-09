namespace RelacionesEntreClasesVideojuego
{
    public class Mago : Personaje
    {
        public int ManaMago {get;set;}
        public Mago(int manamago, string nombrepersonaje, int vidapersonaje, int nivelpersonaje) : base(nombrepersonaje, vidapersonaje, nivelpersonaje)
        {
            ManaMago = manamago;
        }

        public override void MostrarInformacionPersonaje()
        {
            Console.WriteLine($"Este personaje de clase mago se llama {NombrePersonaje}.");
            Console.WriteLine($"Tiene {VidaPersonaje} puntos de vida y está en el nivel {NivelPersonaje}.");
            Console.WriteLine();
            Console.WriteLine($"Los objetos que posee en su inventario son: ");

            foreach(Objeto objeto in ObjetosPersonaje)
            {
                Console.WriteLine($"- Nombre: {objeto.NombreObjeto}");
                Console.WriteLine($"- Tipo objeto: {objeto.TipoObjeto}");
                Console.WriteLine($"- Cantidad: {objeto.Cantidad}");
                Console.WriteLine();
            }

            Console.WriteLine($"Sus puntos de maná son {ManaMago}");
        }

        public override void HabilidadPersonaje()
        {
            Console.WriteLine($"{NombrePersonaje} lanza un hechizo arcano.");
        }
    }
}