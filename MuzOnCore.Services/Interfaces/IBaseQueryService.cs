using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Query;
using System.Threading.Tasks;

namespace MuzOnCore.Services.Interfaces
{
    public interface IBaseQueryService<TEntity, TModel, TSortType>
        where TEntity : class, IEntityBase, new()
    {
        Task<QueryResponse<TModel>> GetAsync(QueryRequest<TSortType> query);
    }
}
