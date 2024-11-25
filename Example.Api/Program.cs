var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app
    .MapGet("/hello-world", () => Results.Ok("hello world"))
    .WithName("HelloWorld")
    ;

app.Run();
