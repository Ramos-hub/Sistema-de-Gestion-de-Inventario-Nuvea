using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class PrimerUsoControler
    {
        public bool VerificarEmpresa()
        {
            return ModeloPrimerUsuario.VerificacionEmpresas();
        }
    }
}
