using RythmSectionCDStore.Data;
using Microsoft.EntityFrameworkCore;

namespace RythmSectionCDStore
{
	public class Startup : IStartup
	{
		public Startup(IConfiguration configuration)
		{
			configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		//This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//DbContext configuration
			_ = services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionStrings")));

			//Services configuration

			//Authentication and authorization

			services.AddSession();

			services.AddControllersWithViews();
		}
		//This method gets called by the runtime. Use this method to configure the HTTP request pipline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				//The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseSession();

			//Authentication & Authorization
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Albums}/{action=Index}/{id?}");
			});

			//Seed database
			AppDbInitializer.Seed(app);
			//AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();

		}



	}
}