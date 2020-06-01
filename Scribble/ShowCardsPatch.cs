using HarmonyLib;

namespace Scribble
{
    [HarmonyPatch(typeof(CompendiumSectionCards), "IsCardUnlockedAndDiscovered")]
    class ShowAllCompendiumCardsPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}