using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domains;
using Task.Infra.Repository.Interfaces;

namespace Task.Infra.Repository.Repositories
{
    public class TaskRepository : ITaskInterface
    {
        private readonly AppDContext _context;

        public TaskRepository(AppDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tasks>> ListarTarefas()
        {
            return await _context.Tasks
                    .AsNoTracking()
                    .ToListAsync();
        }
    }
}
