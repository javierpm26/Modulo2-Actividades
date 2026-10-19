using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Enchufes
{
    class CasaSinOCP
    {
        public void Encender(string aparato)
        {
            if (aparato == "lampara")
            {
                Console.WriteLine("Luz encendida");
            }
            else if (aparato == "cafetera")
            {
                Console.WriteLine("Preparando café");
            }
        }
    }
}
