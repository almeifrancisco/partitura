using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio.unityOfWork;
namespace Repositorio.repo
{
    public class LikeReposotorio: BaseRepositorio<Like>
    {
        public LikeReposotorio(IUnitOfWork unit)
            :base(unit)
            {
            
        }


    }
}
