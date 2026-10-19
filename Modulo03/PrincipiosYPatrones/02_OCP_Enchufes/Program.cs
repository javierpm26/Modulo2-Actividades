namespace OCP_Enchufes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SIN OCP ===");

            CasaSinOCP casaAntigua = new CasaSinOCP();

            casaAntigua.Encender("lampara");
            casaAntigua.Encender("cafetera");

            Console.WriteLine();

            Console.WriteLine("=== CON OCP ===");

            Casa casaNueva = new Casa();

            Lampara lampara = new Lampara();
            Cafetera cafetera = new Cafetera();
            Ventilador ventilador = new Ventilador();

            casaNueva.Encender(lampara);
            casaNueva.Encender(cafetera);

            casaNueva.Encender(ventilador);
        }
    }
}