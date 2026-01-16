using ECommons.Configuration;
using System.Collections.Generic;

namespace AutoRetainerAPI.Configuration;
public class ARDiscardMiniConfig : IEzConfig
{
    public List<uint> DiscardingItems;
    public List<uint> BlacklistedItems;
}
