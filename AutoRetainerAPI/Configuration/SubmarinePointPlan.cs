using ECommons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class SubmarinePointPlan
{
    public string GUID = Guid.NewGuid().ToString();
    public string Name = string.Empty;
    public List<uint> Points = [];
    public bool Delete = false;

    public bool IsModified()
    {
        return Points.Count > 0;
    }

    public bool ShouldSerializeDelete() => false;

    public void CopyFrom(SubmarinePointPlan other)
    {
        Name = other.Name;
        Points = other.Points.JSONClone();
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
