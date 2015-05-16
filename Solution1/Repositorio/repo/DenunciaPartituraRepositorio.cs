using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio.repo
{
    public class DenunciaPartituraRepositorio: BaseRepositorio<DenunciaPartitura>
    {
        public DenunciaPartituraRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
