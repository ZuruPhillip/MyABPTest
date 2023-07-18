using System;
using System.Linq;
using System.Threading.Tasks;
using MyAbp.Demo.Todos.Dtos;
using Volo.Abp.Application.Services;

namespace MyAbp.Demo.Todos;


/// <summary>
/// 
/// </summary>
public class TodoAppService : CrudAppService<Todo, TodoDto, Guid, TodoGetListInput, CreateUpdateTodoDto, CreateUpdateTodoDto>,
    ITodoAppService
{

    private readonly ITodoRepository _repository;

    public TodoAppService(ITodoRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Todo>> CreateFilteredQueryAsync(TodoGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Context.IsNullOrWhiteSpace(), x => x.Context.Contains(input.Context))
            .WhereIf(input.Done != null, x => x.Done == input.Done)
            ;
    }
}
