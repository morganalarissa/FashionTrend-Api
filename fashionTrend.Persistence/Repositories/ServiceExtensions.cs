using fashionTrend.Domain.Interfaces;
using fashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionTrend.Persistence.Repositories
{
    public static class ServiceExtensions
    {
        // usar para configurar a camada de persistencia no EF core
        public static void ConfigurePersistenceApp(
            this IServiceCollection services, IConfiguration configuration)
        {
            // recupera a string de conexao da camada de presentation / api/
            var connectionString = configuration.GetConnectionString("Sqlite");

            // Definir o provedor de banco de dados
            services.AddDbContext<AppDbContext>(
                opt => opt.UseSqlite(connectionString));

            // Toda a construção de escopo da nossa aplicação ficará aqui
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IKafkaProducer, KafkaProducer>();
        }
    }
}
