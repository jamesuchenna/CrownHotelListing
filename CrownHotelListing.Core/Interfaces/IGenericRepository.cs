using CrownHotelListing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace CrownHotelListing.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>,
            IOrderedQueryable<T>> orderby = null, List<string> includes = null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task<IPagedList<T>> GetPageAsync(PaginatorParams paginatorParams, List<string> includes = null);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        void DeleteRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
    }
}
