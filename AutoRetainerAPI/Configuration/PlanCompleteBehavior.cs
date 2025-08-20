using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public enum PlanCompleteBehavior
{
    Restart_plan,
    Assign_Quick_Venture,
    Do_nothing,
    Repeat_last_venture
}
