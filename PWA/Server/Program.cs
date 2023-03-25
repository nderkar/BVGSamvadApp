using Samvad_App.Server.Data;
using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;
using Samvad_App.Server.Services;
using Samvad_App.Shared.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
string jwtIssuer = builder.Configuration["JwtIssuer"];
string jwtAudience = builder.Configuration["JwtAudience"];
string jwtSecurityKey = builder.Configuration["JwtSecurityKey"];
string fileUploadPath = builder.Configuration["FileUploadPath"];
string avatarUploadPath = builder.Configuration["AvatarUploadPath"];


Samvad_App.Shared.Models.AppSettingVariables settings = new Samvad_App.Shared.Models.AppSettingVariables();
builder.Services.AddSingleton(settings);
settings.FileUploadPath = fileUploadPath;
settings.AvatarUploadPath = avatarUploadPath;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>()
		.AddRoles<IdentityRole>()
		.AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddTransient<IRepository<Employee>, EmployeeRepository>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

builder.Services.AddTransient<IRepository<Post>, PostRepository>();
builder.Services.AddTransient<IPostService, PostService>();

builder.Services.AddTransient<IRepository<PostAsset>, PostAssetRepository>();
builder.Services.AddTransient<IPostAssetService, PostAssetService>();

builder.Services.AddTransient<IRepository<ApplicationUser>, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IRepository<PostLike>, PostLikeRepository>();
builder.Services.AddTransient<IPostLikeService, PostLikeService>();

builder.Services.AddTransient<IRepository<PostComment>, PostCommentRespository>();
builder.Services.AddTransient<IPostCommentService, PostCommentService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
		.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = jwtIssuer,
				ValidAudience = jwtAudience,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecurityKey)),
				ClockSkew = TimeSpan.FromSeconds(0)
			};
		});

builder.Services.AddAuthorization(config =>
{
	config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
	config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
});


builder.Services.AddControllers();


// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();



WebApplication app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	//app.UseMigrationsEndPoint();
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
	endpoints.MapRazorPages();
	endpoints.MapFallbackToFile("index.html");
});

app.Run();
