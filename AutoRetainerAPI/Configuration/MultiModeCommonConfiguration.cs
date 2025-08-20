using System.Reflection;

namespace AutoRetainerAPI.Configuration;

[Obfuscation(Exclude = true, ApplyToMembers = true)]
public class MultiModeCommonConfiguration
{
    public bool MultiWaitForAll = false;
    public int AdvanceTimer = 60;
    public bool WaitForAllLoggedIn = false;
    public int MaxMinutesOfWaiting = 0;
}
