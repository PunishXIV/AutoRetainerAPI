using FFXIVClientStructs.FFXIV.Client.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRetainerAPI.Configuration;

public struct SavedInventoryItem
{
    public InventoryItem item;
}

public struct SavedInventoryIdentifier
{
    public ulong ContentId;
    public ulong CarrierId;
    public InventoryType InventoryType;
    public uint InventorySlot;
    public uint ItemId;
    public uint Quantity;
}