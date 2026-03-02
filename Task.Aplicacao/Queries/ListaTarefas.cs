using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Infra;

namespace Task.Aplicacao.Queries
{
    public class  ListaTarefas
    {
        public record  ListaTarefasQuery() : IRequest<IEnumerable<ListaTarefasDto>>;
        public class ListaTarefasDto
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public int Status { get; set; }
            public string Responsavel { get; set; }
            public DateTime? CriadaEm { get; set; }

        }

        public class ListaTarefasQueryHandler : IRequestHandler<ListaTarefasQuery, IEnumerable<ListaTarefasDto>>
        {
            private readonly AppDContext _context;

            public ListaTarefasQueryHandler(AppDContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ListaTarefasDto>> Handle(ListaTarefasQuery request, CancellationToken cancellationToken)
            {
                var tarefas = await _context.Tasks
                    .AsNoTracking()
                    .Select(t => new ListaTarefasDto
                    {
                        Id = t.Id,
                        Titulo = t.Titulo,
                        Descricao = t.Descricao,
                        Status = t.Status,
                        Responsavel = t.Responsavel,
                        CriadaEm = t.CriadaEm
                    })
                    .ToListAsync(cancellationToken);
                return tarefas;

            }
    }
}
