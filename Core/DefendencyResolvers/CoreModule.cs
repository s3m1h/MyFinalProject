using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DefendencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IHttpContextAccessor , HttpContextAccessor>();
        }
    }
}
