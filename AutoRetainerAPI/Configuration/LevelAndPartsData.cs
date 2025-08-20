using System;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]

public class LevelAndPartsData
{
    public string GUID = Guid.NewGuid().ToString();
    public int MinLevel = 1;
    public int MaxLevel = 2;
    public Hull Part1 = Hull.Shark;
    public Stern Part2 = Stern.Shark;
    public Bow Part3 = Bow.Shark;
    public Bridge Part4 = Bridge.Shark;

    public VesselBehavior VesselBehavior = VesselBehavior.Unlock;
    public UnlockMode UnlockMode = UnlockMode.SpamOne;
    public string SelectedUnlockPlan = Guid.Empty.ToString();
    public string SelectedPointPlan = Guid.Empty.ToString();

    public bool FirstSubDifferent;
    public VesselBehavior FirstSubVesselBehavior;
    public UnlockMode FirstSubUnlockMode;
    public string FirstSubSelectedUnlockPlan = Guid.Empty.ToString();
    public string FirstSubSelectedPointPlan = Guid.Empty.ToString();
}

public enum Hull
{
    Shark = 21794,
    Unkiu = 21798,
    Whale = 22528,
    Coelacanth = 23905,
    Syldra = 24346,
    ModShark = 24350,
    ModUnkiu = 24354,
    ModWhale = 24358,
    ModCoelacanth = 24362,
    ModSyldra = 24366
}

public enum Stern
{
    Shark = 21795,
    Unkiu = 21799,
    Whale = 22529,
    Coelacanth = 23906,
    Syldra = 24347,
    ModShark = 24351,
    ModUnkiu = 24355,
    ModWhale = 24359,
    ModCoelacanth = 24363,
    ModSyldra = 24367
}

public enum Bow
{
    Shark = 21792,
    Unkiu = 21796,
    Whale = 22526,
    Coelacanth = 23903,
    Syldra = 24344,
    ModShark = 24348,
    ModUnkiu = 24352,
    ModWhale = 24356,
    ModCoelacanth = 24360,
    ModSyldra = 24364
}

public enum Bridge
{
    Shark = 21793,
    Unkiu = 21797,
    Whale = 22527,
    Coelacanth = 23904,
    Syldra = 24345,
    ModShark = 24349,
    ModUnkiu = 24353,
    ModWhale = 24357,
    ModCoelacanth = 24361,
    ModSyldra = 24365
}
