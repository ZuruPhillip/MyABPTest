using System;
using MyAbp.Demo.Todos.Dtos;
using Volo.Abp.Application.Services;

namespace MyAbp.Demo.Todos;


/// <summary>
/// 
/// </summary>
public interface ITodoAppService :
    ICrudAppService< 
        TodoDto, 
        Guid, 
        TodoGetListInput,
        CreateUpdateTodoDto,
        CreateUpdateTodoDto>
{

}