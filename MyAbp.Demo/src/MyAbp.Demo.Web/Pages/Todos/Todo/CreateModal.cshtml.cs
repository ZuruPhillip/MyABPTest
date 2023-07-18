using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAbp.Demo.Todos;
using MyAbp.Demo.Todos.Dtos;
using MyAbp.Demo.Web.Pages.Todos.Todo.ViewModels;

namespace MyAbp.Demo.Web.Pages.Todos.Todo;

public class CreateModalModel : DemoPageModel
{
    [BindProperty]
    public CreateEditTodoViewModel ViewModel { get; set; }

    private readonly ITodoAppService _service;

    public CreateModalModel(ITodoAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTodoViewModel, CreateUpdateTodoDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}