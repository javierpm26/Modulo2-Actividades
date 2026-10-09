namespace RelacionesEntreClasesVideojuego
{
    public class Guerrero : Personaje
    {
        public int FuerzaGuerrero {get;set;}
        public Guerrero(int fuerzaguerrero, string nombrepersonaje, int vidapersonaje, int nivelpersonaje) : base(nombrepersonaje, vidapersonaje, nivelpersonaje)
        {
            FuerzaGuerrero = fuerzaguerrero;
        }

        public override void MostrarInformacionPersonaje()
        {
            Console.WriteLine($"Este personaje de clase guerrero se llama {NombrePersonaje}.");
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

            Console.WriteLine($"Su estadística de fuerza es {FuerzaGuerrero}");
        }

        public override void HabilidadPersonaje()
        {
            Console.WriteLine($"{NombrePersonaje} realiza un ataque devastador.");
        }
    }
}