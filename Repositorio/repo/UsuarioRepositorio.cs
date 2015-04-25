using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class UsuarioRepositorio: BaseRepositorio<Usuario>
    {
        public UsuarioRepositorio(IUnitOfWork unit)
            :base(unit)
        {
        }
       
    }
}
