namespace app_example_net_core;

public static class ServiceCollectionExtensions
{
    // public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    // {
    //     services.AddDbContext<DatabaseContext>(options =>
    //         {
    //             options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //             options.UseNpgsql(configuration.GetValue<string>("ConnectionStrings:Database")!);
    //         }
    //     );
    //     services.AddScoped<Func<DatabaseContext?>>(provider => provider.GetService<DatabaseContext>);
    //     
    //     AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    //     return services;
    // }
    //
    // /// <summary>
    // /// 
    // /// </summary>
    // /// <param name="services"></param>
    // /// <returns></returns>
    // public static IServiceCollection AddRepositories(this IServiceCollection services)
    // {
    //     services.AddScoped<IUsersRepository, UsersRepository>();
    //     services.AddScoped<IEventsRepository, EventsRepository>();
    //     services.AddScoped<ISettingsRepository, SettingsRepository>();
    //     services.AddScoped<INotificationsRepository, NotificationsRepository>();
    //     return services;
    // }
    //
    // /// <summary>
    // /// 
    // /// </summary>
    // /// <param name="services"></param>
    // /// <returns></returns>
    // public static IServiceCollection AddServices(this IServiceCollection services)
    // {
    //     services.AddScoped<IJwtService, JwtService>();
    //     // services.AddScoped<IJwtUtils, JwtUtils>();
    //     services.AddScoped<IAccountService, AccountService>();
    //     services.AddScoped<IUsersService, UsersService>();
    //     services.AddScoped<IEventsService, EventsService>();
    //     services.AddScoped<ISettingService, SettingService>();
    //     services.AddScoped<INotificationsService, NotificationsService>();
    //     return services;
    // }
    
    
    // /// <summary>
    // /// 
    // /// </summary>
    // /// <param name="services"></param>
    // /// <param name="configuration"></param>
    // /// <exception cref="Exception"></exception>
    // public static void AddSettings(this IServiceCollection services, IConfiguration configuration)
    // {
    //     var mainSettings = configuration.GetSection("MainSettings").Get<MainSettings>();
    //     if (mainSettings == null)
    //         throw new Exception("Section \"MainSettings\" is required in appsettings.json");
    //     services.AddSingleton(mainSettings);
    // }
    //
}