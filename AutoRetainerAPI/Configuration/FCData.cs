using System;

namespace AutoRetainerAPI.Configuration;
[Serializable]
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
