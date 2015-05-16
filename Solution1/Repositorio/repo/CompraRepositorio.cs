using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class CompraRepositorio:BaseRepositorio<Compra>
    {
        public CompraRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
