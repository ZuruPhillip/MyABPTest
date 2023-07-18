using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MyAbp.Demo.Web.Pages.Todos.Todo;

public class IndexModel : DemoPageModel
{
    public TodoFilterInput TodoFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class TodoFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TodoContext")]
    public string Context { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TodoDone")]
    public bool? Done { get; set; }
}
