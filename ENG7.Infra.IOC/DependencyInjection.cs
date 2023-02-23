using ENG7.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ENG7.Infra.IOC
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfraStructure(this IServiceCollection services,
											   IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
			return services;
		}
	}
}
