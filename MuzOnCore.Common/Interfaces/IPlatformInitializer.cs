using Microsoft.Extensions.DependencyInjection;

namespace MuzOnCore.Common.Interfaces
{
    public interface IPlatformInitializer
    {
        void ConfigureServices(IServiceCollection services);
    }
}
