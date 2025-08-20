using ECommons.ExcelServices;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Serializable]
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class HouseDescriptor : IEquatable<HouseDescriptor>
{
    public uint TerritoryType;
    public int Ward;
    public int Plot;

    public HouseDescriptor()
    {
    }

    public HouseDescriptor(uint territoryType, int ward, int plot, bool Unchecked = false) : this()
    {
        if(!Unchecked)
        {
            if(ward < 0) throw new ArgumentOutOfRangeException(nameof(ward));
            if(plot < 0) throw new ArgumentOutOfRangeException(nameof(plot));
        }
        if(territoryType < 1) throw new ArgumentOutOfRangeException(nameof(territoryType));
        TerritoryType = territoryType;
        Ward = ward;
        Plot = plot;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as HouseDescriptor);
    }

    public bool Equals(HouseDescriptor other)
    {
        return other is not null &&
               TerritoryType == other.TerritoryType &&
               Ward == other.Ward &&
               Plot == other.Plot;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(TerritoryType, Ward, Plot);
    }

    public override string ToString()
    {
        return $"[{ExcelTerritoryHelper.GetName(TerritoryType, true)} @ ward={Ward}, plot={Plot}]";
    }

    public static bool operator ==(HouseDescriptor left, HouseDescriptor right)
    {
        return EqualityComparer<HouseDescriptor>.Default.Equals(left, right);
    }

    public static bool operator !=(HouseDescriptor left, HouseDescriptor right)
    {
        return !(left == right);
    }
}
