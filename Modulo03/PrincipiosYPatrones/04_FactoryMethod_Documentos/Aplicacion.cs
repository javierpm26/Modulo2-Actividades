using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Documentos
{
    abstract class Aplicacion
    {
        public abstract IDocumento CrearDocumento();

        public void NuevoDocumento()
        {
            IDocumento documento = CrearDocumento();

            documento.Abrir();
        }
    }
}