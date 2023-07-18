using System.Threading.Tasks;

namespace MyAbp.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
