using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio.repo
{
    public class InstrumentoRepositorio: BaseRepositorio<Instrumento>
    {
        public InstrumentoRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
