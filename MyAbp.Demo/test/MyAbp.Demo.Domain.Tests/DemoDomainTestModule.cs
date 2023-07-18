using MyAbp.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyAbp.Demo;

[DependsOn(
    typeof(DemoEntityFrameworkCoreTestModule)
    )]
public class DemoDomainTestModule : AbpModule
{

}
