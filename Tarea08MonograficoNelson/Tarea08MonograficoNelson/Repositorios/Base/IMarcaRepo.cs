﻿using Tarea08MonograficoNelson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea08MonograficoNelson.Repositorios.Base
{
   public interface IMarcaRepo : IRepoBase<Marca>
    {
        Task<List<Generico>> GetGenericList();
    }
}
