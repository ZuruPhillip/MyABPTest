using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyAbp.Demo.Todos;

/// <summary>
/// 
/// </summary>
public static class TodoEfCoreQueryableExtensions
{
    public static IQueryable<Todo> IncludeDetails(this IQueryable<Todo> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
