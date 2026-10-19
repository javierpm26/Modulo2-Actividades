using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Enchufes
{
    class Lampara : IEnchufable
    {
        public void Encender()
        {
            Console.WriteLine("Luz encendida");
        }
    }
}