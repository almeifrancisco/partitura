using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio.repo
{
    public class CategoriaDaPartituraRepositorio: BaseRepositorio<categoriaDaPartitura>
    {
        public CategoriaDaPartituraRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
