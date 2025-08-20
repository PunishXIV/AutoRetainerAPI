using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class OfflineVesselData
{
    public string Name;
    public uint ReturnTime;

    public OfflineVesselData() { }

    public OfflineVesselData(string name, uint returnTime)
    {
        Name = name;
        ReturnTime = returnTime;
    }

    public OfflineVesselData(uint returnTime, string name)
    {
        Name = name;
        ReturnTime = returnTime;
    }
}
