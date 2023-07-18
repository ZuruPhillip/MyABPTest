using MyAbp.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyAbp.Demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
