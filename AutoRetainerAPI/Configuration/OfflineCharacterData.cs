﻿using Dalamud.Interface;
using ECommons.DalamudServices;
using Lumina.Excel.GeneratedSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    public bool ShowRetainersInDisplayOrder = false;
    public bool ShouldSerializeEnableGCArmoryHandin() => false;
    public GCDeliveryType GCDeliveryType = GCDeliveryType.Disabled;
    public HashSet<uint> UnlockedGatheringItems = new();
    public short[] ClassJobLevelArray = new short[30];
    public uint Gil = 0;
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
    public List<uint> TransferItemsBlacklist = new();
    public int NumSubSlots = 0;
    public bool TeleportToFCHouse = false;
    public bool TeleportToRetainerHouse = false;
    public HouseTeleportTarget HouseTeleportTarget = HouseTeleportTarget.Free_Company_Estate_Hall;
    public Vector3 FCHouseEntrance = default;
    public Vector3 PHouseEntrance = default;

    public string Identity => $"{CID}";
    public bool ShouldSerializeIdentity() => false;

    public string CurrentWorld => WorldOverride ?? World;

    public override string ToString()
    {
        return $"{Name}@{World}";
    }
}
