using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class PartituraRepositorio : BaseRepositorio<Partitura>
    {
        public PartituraRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }

    }
}
