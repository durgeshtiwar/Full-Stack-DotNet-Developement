var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home",() => "Hello this Get method");
//app.MapPost("/Home",() => "Hello this Post method");
//app.MapPut("/Home",() => "Hello this Put method");
//app.MapDelete("/Home",() => "Hello this Delete method");

app.UseRouting();
app.UseEndpoints(endpoints => {

    endpoints.MapGet("/Home", async (context) => 
    {
        await context.Response.WriteAsync("This is the Home paqe");
    }); 
});





//app.MapControllerRoute(
//    name:"default",
//    pattern:"{controller=User}/{action=Index}/{id?}"
//    );
//app.MapControllers();

app.Run();
