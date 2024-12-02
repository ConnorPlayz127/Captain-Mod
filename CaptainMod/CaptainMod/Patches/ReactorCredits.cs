using BepInEx;
using BepInEx.Unity.IL2CPP;
using Reactor.Utilities;
using HarmonyLib;

namespace CaptainMod 
{
    [BepInPlugin("com.captainmod.connorplayz", "Captain Mod", "1.0")]
    [BepInProcess("Among Us.exe")]
    public class CaptainPlugin : BasePlugin
    {
        public Harmony Harmony { get; private set; }

        public override void Load()
        {
            Harmony = new Harmony("com.captainmod.connorplayz");
            Harmony.PatchAll();
            ReactorCredits.Register("Captain Mod - ", "by ConnorPlayz", false, location => location is not ReactorCredits.Location.PingTracker);
            ReactorCredits.Register("Mod Version: ", "1.0dev", false, location => location is not ReactorCredits.Location.PingTracker);
            ReactorCredits.Register("Texture Quality: ", "Extreme", false, location => location is not ReactorCredits.Location.PingTracker);
        }
    }
}