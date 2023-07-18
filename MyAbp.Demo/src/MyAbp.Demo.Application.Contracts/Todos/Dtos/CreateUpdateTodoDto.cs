using System;

namespace MyAbp.Demo.Todos.Dtos;

[Serializable]
public class CreateUpdateTodoDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Context { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool Done { get; set; }
}