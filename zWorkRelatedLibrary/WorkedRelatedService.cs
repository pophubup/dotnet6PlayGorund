using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zWorkRelatedLibrary
{
    public static class WorkedRelatedService
    {
        public static IServiceCollection AddWorkedRelatedService(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<WordUntil>();
            var buidler = service.BuildServiceProvider();
            //buidler.GetService<WordUntil>().ValueReplaceBySeed(configuration["words:SEED"]);
            // buidler.GetService<WordUntil>().RTFFormatToReplaceValue(configuration["words:RTF"]);
            return service;
        }
    }
}
