using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio.repo
{
    public class VendedorRepositorio: BaseRepositorio<Vendedor>
    {
        public VendedorRepositorio(IUnitOfWork unit)
            : base(unit)
        { 
        }
    }
}
