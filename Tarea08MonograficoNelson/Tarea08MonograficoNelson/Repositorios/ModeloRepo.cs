using Tarea08MonograficoNelson.Models;
using Tarea08MonograficoNelson.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Tarea08MonograficoNelson.Repositorios
{
  
        public class ModeloRepo : RepoBase<Modelo>, IModeloRepo
        {
            private readonly AppDbContext _context;
            public ModeloRepo(AppDbContext context) : base(context)
            {
                _context = context;
            }

        }
    
}
