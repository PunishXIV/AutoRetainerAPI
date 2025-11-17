using ECommons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class SubmarineUnlockPlan
{
    public string GUID = Guid.NewGuid().ToString();
    public string Name = string.Empty;
    public List<uint> ExcludedRoutes = [];
    public bool Delete = false;
    public bool UnlockSubs = true;
    public bool EnforceDSSSinglePoint = false;
    public bool EnforcePlan = false;

    public bool IsModified()
    {
        var newPlan = new SubmarineUnlockPlan();
        return ExcludedRoutes.Count > 0
            || Delete != newPlan.Delete
            || Delete != newPlan.UnlockSubs
            || Delete != newPlan.EnforceDSSSinglePoint
            || Delete != newPlan.EnforcePlan;
    }

    public bool ShouldSerializeDelete() => false;

    public void CopyFrom(SubmarineUnlockPlan other)
    {
        Name = other.Name;
        ExcludedRoutes = other.ExcludedRoutes.JSONClone();
        UnlockSubs = other.UnlockSubs;
        EnforceDSSSinglePoint = other.EnforceDSSSinglePoint;
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
