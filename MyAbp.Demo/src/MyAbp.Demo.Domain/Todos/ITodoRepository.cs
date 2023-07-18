using System;
using Volo.Abp.Domain.Repositories;

namespace MyAbp.Demo.Todos;

/// <summary>
/// 
/// </summary>
public interface ITodoRepository : IRepository<Todo, Guid>
{
}
