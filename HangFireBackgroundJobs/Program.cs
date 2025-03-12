using Hangfire;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(conf =>

    conf.UseSimpleAssemblyNameTypeSerializer()
        .UseSimpleAssemblyNameTypeSerializer()
        .UseInMemoryStorage()
);
builder.Services.AddHangfireServer(srv => srv.SchedulePollingInterval = TimeSpan.FromSeconds(2));
var app = builder.Build();
app.UseHangfireDashboard();
app.MapGet("/job", (IBackgroundJobClient jobClient,IRecurringJobManager jobManager) =>
{
    //TO ENQUEUE
    //jobClient.Enqueue(() => Console.WriteLine("Do it"));

    //Run AFTER SomeTime
    jobClient.Schedule(() => Console.WriteLine("Do it 3 Times"),TimeSpan.FromSeconds(3));

    jobManager.AddOrUpdate("every5seconds",() => Console.WriteLine("Do it 5 Times"), "*/5 * * * *");
    return Results.Ok("");
});
app.Run();