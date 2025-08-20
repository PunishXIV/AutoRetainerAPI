using ECommons.DalamudServices;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Serializable]
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class OfflineCharacterData
{
    public readonly ulong CreationFrame = Svc.PluginInterface.UiBuilder.FrameCount;
    public bool ShouldSerializeCreationFrame => false;
    public ulong CID = 0;
    public string Name = "Unknown";
    public string World = "";
    public string WorldOverride = null;
    public bool Enabled = false;
    public bool WorkshopEnabled = false;
    public List<OfflineRetainerData> RetainerData = new();
    public bool Preferred = false;
    public uint Ventures = 0;
    public uint InventorySpace = 0;
    public uint VentureCoffers = 0;
    public int ServiceAccount = 0;
    public bool EnableGCArmoryHandin = false; //todo: remove
    public bool ShouldSerializeEnableGCArmoryHandin() => false;
    public GCDeliveryType GCDeliveryType = GCDeliveryType.Disabled;
    public HashSet<uint> UnlockedGatheringItems = new();
    public short[] ClassJobLevelArray = new short[30];
    public uint Gil = 0;
    public uint GCSeals = 0;
    public uint GCRank = 0;
    public List<OfflineVesselData> OfflineAirshipData = new();
    public List<OfflineVesselData> OfflineSubmarineData = new();
    public HashSet<string> EnabledAirships = new();
    public HashSet<string> EnabledSubs = new();
    //public HashSet<string> FinalizeAirships = new();
    //public HashSet<string> FinalizeSubs = new();
    public Dictionary<string, AdditionalVesselData> AdditionalAirshipData = new();
    public Dictionary<string, AdditionalVesselData> AdditionalSubmarineData = new();
    public int Ceruleum = 0;
    public int RepairKits = 0;
    public bool ExcludeRetainer = false;
    public bool ExcludeWorkshop = false;
    public bool ExcludeOverlay = false;
    public int NumSubSlots = 0;
    public bool MultiWaitForAllDeployables = false;
    public ulong FCID = 0;
    public bool DisablePrivateHouseTeleport = false;
    public bool DisableFcHouseTeleport = false;
    public bool DisableApartmentTeleport = false;
    public TeleportOptionsOverride TeleportOptionsOverride = new();
    public bool NoGilTrack = false;
    public Guid ExchangePlan = Guid.Empty;
    public Guid InventoryCleanupPlan = Guid.Empty;

    public string Identity => $"{CID}";
    public bool ShouldSerializeIdentity() => false;

    public string CurrentWorld => WorldOverride ?? World;

    public override string ToString()
    {
        return $"{Name}@{World}";
    }
}
