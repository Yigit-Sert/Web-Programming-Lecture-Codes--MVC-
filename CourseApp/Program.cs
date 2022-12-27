var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllers();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//localhost:5000/course/list
//localhost:5000/course/details

app.UseRouting();
app.UseEndpoints(endpoints=>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=home}/{action=index}/{id?}"
    );
});


app.Run();
