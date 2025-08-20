using System.Reflection;

namespace AutoRetainerAPI.Configuration;
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class TeleportOptionsOverride
{
    public bool? Enabled = null;
    public bool? Retainers = null;
    public bool? RetainersPrivate = null;
    public bool? RetainersFC = null;
    public bool? RetainersApartment = null;
    public bool? Deployables = null;
}
