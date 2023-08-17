using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/", () => "Hello World .. !");

//app.UseStaticFiles();
//app.UseStaticFiles("/StaticFiles");
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider($"{app.Environment.ContentRootPath}\\StaticFiles")
});

app.Run();
