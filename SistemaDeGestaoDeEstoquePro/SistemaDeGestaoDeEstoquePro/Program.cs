using Microsoft.EntityFrameworkCore;
using SistemaDeGestaoDeEstoquePro.Data;
using SistemaDeGestaoDeEstoquePro.Service.Admin;
using SistemaDeGestaoDeEstoquePro.Service.Estoque;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Registrar e configurar o contexto para ser utilizado pela aplicação
builder.Services.AddDbContext<ApplicationDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))

);


builder.Services.AddScoped<AdminInterface, AdminService>();
builder.Services.AddScoped<EstoqueInterface, EstoqueService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Estoque}/{action=Estoque}/{id?}")
    .WithStaticAssets();


app.Run();
