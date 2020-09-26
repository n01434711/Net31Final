using Microsoft.Extensions.Configuration;
using System.IO;

namespace Net31.Wynnie.FinalExam.EntityFrameworkDataAccess
{
    public static class ConnectionStringUtil
    {
        public static string GetConnectionString()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            return root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }
    }
}
