using System;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;
[Serializable]
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class FCData
{
    public ulong ID;
    public string Name;
    public long Gil = -1;
    public bool GilCountsTowardsChara = false;
    public long LastGilUpdate;
    public long FCPoints;
    public long FCPointsLastUpdate;
    public ulong HolderChara;
}
