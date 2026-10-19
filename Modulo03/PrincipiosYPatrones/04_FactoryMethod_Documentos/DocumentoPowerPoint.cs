using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Documentos
{
    class DocumentoPowerPoint : IDocumento
    {
        public void Abrir()
        {
            Console.WriteLine("Abriendo presentación PowerPoint");
        }
    }
}