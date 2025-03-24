using Scalar.AspNetCore;

namespace GamePlannerAPI.StartUp;

public static class OpenApiCOnfig
{
    public static void AddOpenAPIServices(this IServiceCollection services)
    {
        services.AddOpenApi();
    }

    public static void UseOpenApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.HideClientButton = true;
            });
        }
    }
}