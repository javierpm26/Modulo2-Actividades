using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Documentos
{
    class DocumentoExcel : IDocumento
    {
        public void Abrir()
        {
            Console.WriteLine("Abriendo documento Excel");
        }
    }
}