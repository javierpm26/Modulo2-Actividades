using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Documentos
{
    class AplicacionPowerPoint : Aplicacion
    {
        public override IDocumento CrearDocumento()
        {
            return new DocumentoPowerPoint();
        }
    }
}