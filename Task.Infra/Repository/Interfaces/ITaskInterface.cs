using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domains;

namespace Task.Infra.Repository.Interfaces
{
    public interface ITaskInterface
    {
        Task<IEnumerable<Tasks>> ListarTarefas();
    }
}
