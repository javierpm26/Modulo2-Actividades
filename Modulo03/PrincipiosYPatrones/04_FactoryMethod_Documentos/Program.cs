namespace FactoryMethod_Documentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FACTORY METHOD ===");

            Aplicacion word = new AplicacionWord();
            Aplicacion excel = new AplicacionExcel();
            Aplicacion powerpoint = new AplicacionPowerPoint();

            word.NuevoDocumento();
            excel.NuevoDocumento();
            powerpoint.NuevoDocumento();
        }
    }
}