using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum HouseTeleportTarget
{
    Private_Estate_Hall, Free_Company_Estate_Hall, Apartment
}
