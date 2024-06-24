using Microsoft.Extensions.DependencyInjection;

namespace LK.Service;

public static class ProjectSetup
{
    public static void AddLKServices(this IServiceCollection services)
    {
        Console.WriteLine("Add LK.Service services");
    }
}