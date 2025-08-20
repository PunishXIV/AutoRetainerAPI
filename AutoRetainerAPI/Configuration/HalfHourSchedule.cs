using ECommons.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoRetainerAPI.Configuration;
[Serializable]
[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class HalfHourSchedule
{
    public Dictionary<int, IntervalState> Intervals = [];

    public void SetState(int intervalIndex, IntervalState state)
    {
        if(!IsValidIndex(intervalIndex))
        {
            PluginLog.Error($"Invalid interval index: {intervalIndex}");
            return;
        }

        if(state == IntervalState.Active)
        {
            Intervals.Remove(intervalIndex);
        }
        else
        {
            Intervals[intervalIndex] = state;
        }
    }

    public IntervalState GetState(int intervalIndex)
    {
        if(!IsValidIndex(intervalIndex))
        {
            PluginLog.Error($"Invalid interval index: {intervalIndex}");
            return IntervalState.Inactive;
        }

        if(Intervals.TryGetValue(intervalIndex, out var state))
        {
            return state;
        }
        return IntervalState.Active;
    }

    public IntervalState GetCurrentState()
    {
        return GetStateAt(DateTime.Now);
    }

    public IntervalState GetStateAt(DateTime time)
    {
        var index = GetIntervalIndex(time);
        return GetState(index);
    }

    private static int GetIntervalIndex(DateTime time)
    {
        var totalMinutes = time.Hour * 60 + time.Minute;
        return totalMinutes / 30;
    }

    private static bool IsValidIndex(int index)
    {
        return index >= 0 && index < 48;
    }
}