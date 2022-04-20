using Telamingo.BusinessLogic.Actions.Calculation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddRazorPages(options =>
//{
//    options.Conventions.AuthorizePage("/aboutUs");
//    options.Conventions.AuthorizeFolder("/Pages");
//});
//builder.Services.AddMvc().AddRazorPagesOptions(options =>
//{
//    options.Conventions.AddPageRoute(pageName: "/ContactUs", route: "");
//});

builder.Services.AddRazorPages();

builder.Services.AddScoped<ICalculationService, CalculationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
