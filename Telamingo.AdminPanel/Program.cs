using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Telamingo.BusinessLogic.AdminService;
using Telamingo.BusinessLogic.Identity.GenerateToken;
using Telamingo.BusinessLogic.Identity.VerifyToken;
using Telamingo.BusinessLogic.Login;
using Telamingo.Domain.AggregateModels.AdminAggregate;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Infrastructure;
using Telamingo.Infrastructure.Repositories.AdminRepository;
using Telamingo.Infrastructure.Repositories.UserRepository;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.Conventions.AddPageRoute("/Sign_in", "");
});

//builder.Services.AddMediatR(typeof(Program));
builder.Services.AddHttpContextAccessor();

//builder.Services.AddMvc()
//    .AddSessionStateTempDataProvider();
//builder.Services.AddHttpClient("AccountClient", c => //Named Http Client
//            {
//    c.DefaultRequestHeaders.Add("X-Custom-Env", "TEST");
//});

//builder.Services.AddAuthentication(x =>
//{
//    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer("Bearer", jwtBearerOptions =>
//{
//    jwtBearerOptions.Authority = Constants.IdentityOptions.IdentityUrl;

//    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateAudience = false
//    };
//});

//For Entity Framework
builder.Services.AddDbContext<TelamingoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));
builder.Services.AddScoped<TelamingoDbContext>();

//For Identity
builder.Services.AddIdentity<Admin, AdminRole>()
    .AddEntityFrameworkStores<TelamingoDbContext>()
    .AddDefaultTokenProviders();

var myCorsPolicy = "MyCorsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(myCorsPolicy,
        builder =>
        {
            builder.AllowAnyOrigin()
            .WithExposedHeaders("x-my-custom-header");
        });
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Jwt", policy =>
    {
        policy.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
        policy.RequireAuthenticatedUser();
    });
});
//Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
 //Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
options.RequireHttpsMetadata = false;
options.TokenValidationParameters = new TokenValidationParameters()
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidAudience = Configuration["JWT:Audience"],
    ValidIssuer = Configuration["JWT:Issuer"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]))
};
});

//builder.Services.AddSwaggerGen(c => {
//    c.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Title = "JWTToken_Auth_API",
//        Version = "v1"
//    });
//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
//    {
//        Name = "Authorization",
//        Type = SecuritySchemeType.ApiKey,
//        Scheme = "Bearer",
//        BearerFormat = "JWT",
//        In = ParameterLocation.Header,
//        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
//    });
//    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
//        {
//            new OpenApiSecurityScheme {
//                Reference = new OpenApiReference {
//                    Type = ReferenceType.SecurityScheme,
//                        Id = "Bearer"
//                }
//            },
//            new string[] {}
//        }
//    });
//});


//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<IVerifyTokenService, VerifyTokenService>();
builder.Services.AddTransient<IGenerateTokenService, GenerateTokenService>();
builder.Services.AddTransient<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IAdminService, AdminService>();


builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseDatabaseErrorPage();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//}
//else
//{
//    app.UseExceptionHandler("./Error");
//}

// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

//app.UseEndpoints(endpoints =>
//{
//    //endpoints.MapControllers();
//    endpoints.MapRazorPages();
//});
//app.UseMvc();



//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//if (app.Environment.IsDevelopment())
//{
//    IdentityModelEventSource.ShowPII = true;
//}
//app.UseSwaggerUI(options =>
//{
//    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//    options.RoutePrefix = string.Empty;
//});


app.MapRazorPages();

app.Run();
