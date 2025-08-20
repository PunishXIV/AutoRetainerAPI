using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum UnavailableVentureDisplay
{
    Hide, Display, Allow_selection
}
