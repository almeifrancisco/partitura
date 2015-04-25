using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class ContatoRepositorio:BaseRepositorio<ContatoRepositorio>
    {
        public ContatoRepositorio(IUnitOfWork unit)
            :base(unit)
        {
        }
    }
}
