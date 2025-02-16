using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
namespace CV.Shared;

public static class ServiceCollectionExtensions
{
    public static void AddCVServices(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddBlazorise(options =>
        {
            options.Immediate = true;
            options.ProductToken = "CjxRBHB/NQ8+UQN3fTc1BlEAc3s0CTxWAHh+MAk4bjoNJ2ZdYhBVCCo/Cj5aAkxERldhE1EvN0xcNm46FD1gSkUHCkxESVFvBl4yK1FBfAYKAiFoVXkNWTU3CDJTPHQAGkR/Xip0HhFIeVQ8bxMBUmtTPApwfjUIPG46HhFEbVgscw4DVXRJN3UeEUh5VDxvEwFSa1M8CnB+NQg8bjoeEUZwTTFkEhFadU07bx4cSm9fPG97fzUIAWlvHgJMa1g1eQQZWmdBImgeEVd3WzBvHnQ0CDxTAExEWmdYMXUEGEx9WzxvDA9dZ1MxfxYdWmc2UgBxfggySg9xOX5cejg0GwQqTF05V3IpKVFSSRl6Oy90VXoTQRsfaE98AAETeDd1OQhzJzZpa1wJdC4acE9lTAkID0d6TwFDDwgqXUQrWwcscl1pG1oEH3drRShWMC9XXEhacwwNNXI9EVZ0IHZ0XiIJDQZcbHsSRDYsZhdpO2gqZUAIPFd0Jx9GCGsbfA8rRkxgO2ItNn1gRixGAj5jCmlUAXYtaEpqB3wsA0t/ZQZ1fA==";
        })
        .AddBootstrapProviders()
        .AddFontAwesomeIcons();
        services.AddLocalization();
    }
}
