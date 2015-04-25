using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class IntrumentoNaPartituraRepositorio: BaseRepositorio<InstrumentosNaPartitura>
    {
        public IntrumentoNaPartituraRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
