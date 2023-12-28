using LabWebApi.Web.Extensions;
using LabWevAPI.Database;
using Microsoft.AspNetCore.SpaServices.AngularCli;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityDbContext();
//Custom swagger
builder.Services.AddSwagger();
builder.Services.AddAutoMapper();
//Services
builder.Services.AddCustomServices();
//Configure JWT
builder.Services.ConfigJwtOptions(builder.Configuration.GetSection("JwtOptions"));
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.ConfigureImageSettings(builder.Configuration);
//Infrastructure
builder.Services.AddRepositories();
builder.Services.AddDbContext(builder.Configuration.GetConnectionString("DefaultConnection"));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.AddSystemRolesToDb();
}
app.ConfigureCustomExceptionMiddleware();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(c =>
{
    c.AllowAnyOrigin();
    c.AllowAnyHeader();
    c.AllowAnyMethod();
});
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
//app.UseSpa(spa =>
//{
//    spa.Options.SourcePath = "ClientApp";
//    spa.UseAngularCliServer(npmScript: "start");
//});
app.Run();