using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class PartituraRepositorio : BaseRepositorio<Partitura>
    {
        public UnitOfWork unit; 

        public PartituraRepositorio(UnitOfWork unit)
            : base(unit)
        {
            this.unit = unit;
        }

    }
}
