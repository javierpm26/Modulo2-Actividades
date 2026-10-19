using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Enchufes
{
    class Casa
    {
        public void Encender(IEnchufable aparato)
        {
            aparato.Encender();
        }
    }
}