using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyAbp.Demo.Todos
{
    public class Todo : FullAuditedEntity<Guid>
    {
        public string Context { get;set; }
        public bool Done { get; set; }

    protected Todo()
    {
    }

    public Todo(
        Guid id,
        string context,
        bool done
    ) : base(id)
    {
        Context = context;
        Done = done;
    }
    }
}
