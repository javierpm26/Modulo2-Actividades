using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Enchufes
{
    class Ventilador : IEnchufable
    {
        public void Encender()
        {
            Console.WriteLine("Ventilador encendido");
        }
    }
}