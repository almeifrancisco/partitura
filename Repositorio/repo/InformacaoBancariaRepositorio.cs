using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class InformacaoBancariaRepositorio: BaseRepositorio<InformacaoBancaria>
    {
        public InformacaoBancariaRepositorio(IUnitOfWork unit)
            :base(unit)
        {
        }
    }
}

