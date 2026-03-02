using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Aplicacao.Queries
{
    public class  ListaTarefas
    {
        public ListaTarefasQuery() :IRequest<Enumerable<ListaTarefasDto>>;
        public class ListaTarefasDto
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public int Status { get; set; }
            public string Responsavel { get; set; }
            public DateTime? CriadaEm { get; set; }

        }

        public class ListaTarefasQueryHandler : IRequestHandler<>
        {
            
        }
    }
}
