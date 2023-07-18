using System;
using Volo.Abp.Application.Dtos;

namespace MyAbp.Demo.Todos.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class TodoDto : FullAuditedEntityDto<Guid>
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