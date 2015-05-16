using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using Repositorio.unityOfWork;

namespace Repositorio.repo
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco> 
    {
    
        
        public EnderecoRepositorio(IUnitOfWork unit)
            : base(unit)
        {              
        }

    }
}
