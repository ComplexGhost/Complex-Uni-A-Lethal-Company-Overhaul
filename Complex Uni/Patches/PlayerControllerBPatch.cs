using GameNetcodeStuff;
using HarmonyLib;

namespace Complex_Uni.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void InfiniteSprintPatch(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;
        }
    }
}
