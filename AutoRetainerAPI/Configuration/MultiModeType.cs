using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum MultiModeType
{
    Retainers, Submersibles, Everything
}
