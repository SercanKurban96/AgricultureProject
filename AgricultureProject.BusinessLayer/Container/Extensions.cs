using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.Concrete;
using AgricultureProject.DataAccessLayer.Abstract;
using AgricultureProject.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServiceServiceBL, ServiceManagerBL>();
            services.AddScoped<IServiceDAL, EfServiceDAL>();

            services.AddScoped<ITeamServiceBL, TeamManagerBL>();
            services.AddScoped<ITeamDAL, EfTeamDAL>();

            services.AddScoped<IAnnouncementServiceBL, AnnouncementManagerBL>();
            services.AddScoped<IAnnouncementDAL, EfAnnouncementDAL>();

            services.AddScoped<IImageServiceBL, ImageManagerBL>();
            services.AddScoped<IImageDAL, EfImageDAL>();

            services.AddScoped<IAddressServiceBL, AddressManagerBL>();
            services.AddScoped<IAddressDAL, EfAddressDAL>();

            services.AddScoped<IContactServiceBL, ContactManagerBL>();
            services.AddScoped<IContactDAL, EfContactDAL>();

            services.AddScoped<ISocialMediaServiceBL, SocialMediaManagerBL>();
            services.AddScoped<ISocialMediaDAL, EfSocialMediaDAL>();

            services.AddScoped<IAboutServiceBL, AboutManagerBL>();
            services.AddScoped<IAboutDAL, EfAboutDAL>();

            services.AddScoped<IAdminServiceBL, AdminManagerBL>();
            services.AddScoped<IAdminDAL, EfAdminDAL>();
        }
    }
}
