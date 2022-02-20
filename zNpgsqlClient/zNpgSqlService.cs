using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace zNpgsqlClient
{
    public static class zNpgSqlService
    {
        public static IServiceCollection AddNpgsql(this IServiceCollection service, string conn)
        {
            service.AddPooledDbContextFactory<_Test3Context>(options => options
   .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
   .UseNpgsql("Host=ls-4d67eb0d3e5a4593522a60644a188bea651c79ed.cwdxwfoovuek.ap-northeast-2.rds.amazonaws.com; Port=5432; Database=Test3; User Id=dbmasteruser; Password=Home7996;", x => x.MigrationsAssembly(typeof(_Test3Context).Assembly.FullName)));
            //var buidler = service.BuildServiceProvider();
            //IDbContextFactory < Test2Context > dbContext = buidler.GetService<IDbContextFactory<Test2Context>>();

            return service;
        }
    }
   
}
