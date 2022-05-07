using Microsoft.Extensions.Configuration;

namespace Infrastructure;

public static class DbConfig
{
    public static string TelamingoContextConnectionString(this IConfiguration config)
    {
        return config.GetConnectionString("TelamingoContext");
    }
}
