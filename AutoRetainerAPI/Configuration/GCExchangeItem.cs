using ECommons.DalamudServices;
using Lumina.Excel;
using Lumina.Excel.Sheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public sealed unsafe class GCExchangeItem
{
    public string ID = Guid.NewGuid().ToString();
    public bool ShouldSerializeID() => false;

    public uint ItemID;
    public int Quantity;
    public int QuantitySingleTime;

    public GCExchangeItem()
    {
    }

    public GCExchangeItem(uint itemID, int quantity)
    {
        ItemID = itemID % 1_000_000;
        Quantity = quantity;
    }

    public RowRef<Item> Data => new(Svc.Data.Excel, ItemID);
    public bool ShouldSerializeData() => false;
}