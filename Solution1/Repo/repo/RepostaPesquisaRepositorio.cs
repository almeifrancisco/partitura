using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class RepostaPesquisaRepositorio: BaseRepositorio<RespostaPesquisa>
    {
        public RepostaPesquisaRepositorio(IUnitOfWork unit)
            : base(unit)
        { }
    }
}
