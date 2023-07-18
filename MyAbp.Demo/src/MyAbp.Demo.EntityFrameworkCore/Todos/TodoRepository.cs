using System;
using System.Linq;
using System.Threading.Tasks;
using MyAbp.Demo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyAbp.Demo.Todos;

public class TodoRepository : EfCoreRepository<DemoDbContext, Todo, Guid>, ITodoRepository
{
    public TodoRepository(IDbContextProvider<DemoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Todo>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}