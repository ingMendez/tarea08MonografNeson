using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea08MonograficoNelson.Models
{
    public class Generico
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public Generico()
		{
			Id = string.Empty;
			Name = string.Empty;
		}
	}
}
