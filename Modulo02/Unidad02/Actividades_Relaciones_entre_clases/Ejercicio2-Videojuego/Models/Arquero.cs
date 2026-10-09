namespace RelacionesEntreClasesVideojuego
{
    public class Arquero : Personaje
    {
        public int FlechasArquero {get;set;}
        public Arquero(int flechasarquero, string nombrepersonaje, int vidapersonaje, int nivelpersonaje) : base(nombrepersonaje, vidapersonaje, nivelpersonaje)
        {
            FlechasArquero = flechasarquero;
        }

        public override void MostrarInformacionPersonaje()
        {
            Console.WriteLine($"Este personaje de clase arquero se llama {NombrePersonaje}.");
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

            Console.WriteLine($"El número de flechas con las que cuenta es {FlechasArquero}");
        }

        public override void HabilidadPersonaje()
        {
            Console.WriteLine($"{NombrePersonaje} realiza un disparo preciso.");
        }
    }
}