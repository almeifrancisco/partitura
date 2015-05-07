using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class CategoriaPRepositorio: BaseRepositorio<CategoriaPRepositorio>
    {
        public CategoriaPRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
