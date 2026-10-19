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

            casaNueva.Encender(new Lampara());
            casaNueva.Encender(new Cafetera());
            casaNueva.Encender(new Ventilador());
        }
    }
}