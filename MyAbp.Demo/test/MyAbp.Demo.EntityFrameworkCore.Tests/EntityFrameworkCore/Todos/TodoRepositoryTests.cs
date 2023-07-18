using System;
using System.Threading.Tasks;
using MyAbp.Demo.Todos;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MyAbp.Demo.EntityFrameworkCore.Todos;

public class TodoRepositoryTests : DemoEntityFrameworkCoreTestBase
{
    private readonly ITodoRepository _todoRepository;

    public TodoRepositoryTests()
    {
        _todoRepository = GetRequiredService<ITodoRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
