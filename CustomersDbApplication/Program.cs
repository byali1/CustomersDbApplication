using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Abstract.PasswordHashing;
using DataAccess.Concrete.AdoNet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace CustomersDbApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var loginPage = serviceProvider.GetRequiredService<LoginPage>();
            Application.Run(loginPage);

            if (loginPage.isSignInSuccess)
            {
                var homePage = serviceProvider.GetRequiredService<HomePage>();
                Application.Run(homePage);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDbContext, CustomersDbContext>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IUserDal, AdoNetUserDal>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<LoginPage>();
            services.AddScoped<HomePage>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();

            // Register other services here
        }
    }
}