using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Documentos
{
    class AplicacionWord : Aplicacion
    {
        public override IDocumento CrearDocumento()
        {
            return new DocumentoWord();
        }
    }
}