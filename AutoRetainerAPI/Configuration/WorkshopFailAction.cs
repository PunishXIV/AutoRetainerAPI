using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum WorkshopFailAction
{
    ExcludeChar, ExcludeVessel, StopPlugin
}
