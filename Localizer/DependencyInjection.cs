using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Localizer
{
    
        public static class DependencyInjection
        {
            public static IServiceCollection AddMVCServices(this IServiceCollection services)
            {
                

                services.AddLocalization(opt => opt.ResourcesPath = "Resources");
                services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
                services.Configure<RequestLocalizationOptions>(opt =>
                {
                    var supCultures = new List<CultureInfo>()
                    {
                        new CultureInfo("tr"),
                        new CultureInfo("en")


                    };

                    opt.DefaultRequestCulture = new RequestCulture("tr");
                    opt.SupportedUICultures = supCultures;
                    opt.SupportedCultures = supCultures;
                });
                return services;
            }
        }

}

