using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domains
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public string Responsavel { get; set; }
        public DateTime? CriadaEm { get; set; }
        public DateTime? AtualizadaEm { get; set; }
        public DateTime? concluidaEm { get; set; }
        public DateTime? deletadaEm { get; set; }

    }
}