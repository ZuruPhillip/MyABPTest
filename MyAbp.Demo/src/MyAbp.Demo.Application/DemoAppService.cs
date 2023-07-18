using System;
using System.Collections.Generic;
using System.Text;
using MyAbp.Demo.Localization;
using Volo.Abp.Application.Services;

namespace MyAbp.Demo;

/* Inherit your application services from this class.
 */
public abstract class DemoAppService : ApplicationService
{
    protected DemoAppService()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
