using MyAbp.Demo.Todos;
using MyAbp.Demo.Todos.Dtos;
using AutoMapper;

namespace MyAbp.Demo;

public class DemoApplicationAutoMapperProfile : Profile
{
    public DemoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Todo, TodoDto>();
        CreateMap<CreateUpdateTodoDto, Todo>(MemberList.Source);
    }
}
