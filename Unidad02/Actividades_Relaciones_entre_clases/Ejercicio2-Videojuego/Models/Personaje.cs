namespace RelacionesEntreClasesVideojuego
{
    public abstract class Personaje
    {
        public string NombrePersonaje {get;set;}
        public int VidaPersonaje {get;set;}
        public int NivelPersonaje {get;set;}
        public List<Objeto> ObjetosPersonaje {get;set;}

        public Personaje(string nombrepersonaje, int vidapersonaje, int nivelpersonaje)
        {
            NombrePersonaje = nombrepersonaje;
            VidaPersonaje = vidapersonaje;
            NivelPersonaje = nivelpersonaje;
            ObjetosPersonaje = new List<Objeto>();
        }

        public void AnadirObjeto(Objeto objeto)
        {
            this.ObjetosPersonaje.Add(objeto);
        }
        public abstract void MostrarInformacionPersonaje();
        public abstract void HabilidadPersonaje();
    }
}
