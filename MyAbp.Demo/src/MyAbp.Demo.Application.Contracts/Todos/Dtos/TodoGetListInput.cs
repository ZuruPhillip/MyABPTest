using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace MyAbp.Demo.Todos.Dtos;

[Serializable]
public class TodoGetListInput : PagedAndSortedResultRequestDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Context { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Done { get; set; }
}