using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Abstract.PasswordHashing;
using DataAccess.Concrete;
using DataAccess.Concrete.AdoNet;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IDbContext dbContext = new CustomersDbContext();
            IPasswordHasher passwordHasher = new PasswordHasher();
            IUserDal userDal = new AdoNetUserDal(dbContext, passwordHasher);


            IUserService userService = new UserManager(userDal);


            ApplicationConfiguration.Initialize();
            //Application.Run(new HomePage(dbContext));

            Application.Run(new LoginPage(userService,dbContext));
        }
    }
}