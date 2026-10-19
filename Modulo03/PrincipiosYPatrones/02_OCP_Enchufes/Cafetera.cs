using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Enchufes
{
    class Cafetera : IEnchufable
    {
        public void Encender()
        {
            Console.WriteLine("Preparando café");
        }
    }
}