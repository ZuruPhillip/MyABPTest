using MyAbp.Demo.Todos.Dtos;
using MyAbp.Demo.Web.Pages.Todos.Todo.ViewModels;
using AutoMapper;

namespace MyAbp.Demo.Web;

public class DemoWebAutoMapperProfile : Profile
{
    public DemoWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<TodoDto, CreateEditTodoViewModel>();
        CreateMap<CreateEditTodoViewModel, CreateUpdateTodoDto>();
    }
}
