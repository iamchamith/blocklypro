using System.Linq;
using System.Threading.Tasks;
using Blockly.Core.Domain;

namespace Blockly.Core.Infrastructure
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);
        Task Delete(int id);
        Task Update(T entity);
        Task<T> Read(int id);
        IQueryable<T> TableAsNoTracking { get;}
        IQueryable<T> Table { get; }
    }
}
