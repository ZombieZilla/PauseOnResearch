using Verse;
using RimWorld;
using System.Reflection;
using HarmonyLib;

namespace Pause_On_Research
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var harmony = new Harmony("com.zilla.pauseonresearch");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Log.Message("launching with logspam™️");
        }
    }

    [HarmonyPatch(typeof(ResearchManager), "FinishProject")]
    class Patch
    {
        static void Prefix(bool doCompletionDialog)
            {
                Find.TickManager.TogglePaused();
            }
    }
}  
