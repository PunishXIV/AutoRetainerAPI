using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Serializable]
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class VenturePlan
{
    [NonSerialized] public string GUID = Guid.NewGuid().ToString();
    public string Name = "";
    public List<PlannedVenture> List = [];
    public PlanCompleteBehavior PlanCompleteBehavior = PlanCompleteBehavior.Restart_plan;

    public List<uint> ListUnwrapped
    {
        get
        {
            var ret = new List<uint>();
            foreach(var v in List)
            {
                for(var i = 0; i < v.Num; i++)
                {
                    ret.Add(v.ID);
                }
            }
            return ret;
        }
    }

    public bool ShouldSerializeListUnwrapped() => false;
}
