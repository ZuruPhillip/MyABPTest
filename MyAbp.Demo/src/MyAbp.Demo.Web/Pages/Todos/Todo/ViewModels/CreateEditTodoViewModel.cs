using System;
using System.ComponentModel.DataAnnotations;

namespace MyAbp.Demo.Web.Pages.Todos.Todo.ViewModels;

public class CreateEditTodoViewModel
{
    [Display(Name = "TodoContext")]
    public string Context { get; set; }

    [Display(Name = "TodoDone")]
    public bool Done { get; set; }
}
