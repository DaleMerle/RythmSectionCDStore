namespace RythmSectionCDStore
{
	public interface IStartup
	{
		IConfiguration Configuration { get; }

		void Configure(IApplicationBuilder app, IWebHostEnvironment env);
		void ConfigureServices(IServiceCollection services);
	}
}