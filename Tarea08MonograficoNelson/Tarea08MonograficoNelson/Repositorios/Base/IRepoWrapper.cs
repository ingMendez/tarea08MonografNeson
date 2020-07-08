using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea08MonograficoNelson.Repositorios.Base
{
    public interface IRepoWrapper
    {
        //Solo colocamos las propiedades tipo get.
        IModeloRepo Modelo { get; }
        IMarcaRepo Marca { get; }
    }
}
