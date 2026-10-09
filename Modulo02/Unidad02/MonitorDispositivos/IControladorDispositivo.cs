namespace MonitorDispositivos
{
    public interface IControladorDispositivo
    {
        string Nombre { get; }
        bool Disponible { get; }
        string ObtenerEstado();
        void Reiniciar();

    }
}
