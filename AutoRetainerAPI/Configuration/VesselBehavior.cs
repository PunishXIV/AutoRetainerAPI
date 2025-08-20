using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum VesselBehavior
{
    Finalize, Redeploy, LevelUp, Unlock, Use_plan
}
