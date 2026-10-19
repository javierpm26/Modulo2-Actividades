namespace SRP_Restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SIN SRP ===");

            Restaurante restaurante = new Restaurante();

            restaurante.Cocinar();
            restaurante.Atender();
            restaurante.LlevarCuentas();

            Console.WriteLine();

            Console.WriteLine("=== CON SRP ===");

            Cocinero cocinero = new Cocinero();
            Camarero camarero = new Camarero();
            Contable contable = new Contable();

            cocinero.Cocinar();
            camarero.Atender();
            contable.LlevarCuentas();
        }
    }
}