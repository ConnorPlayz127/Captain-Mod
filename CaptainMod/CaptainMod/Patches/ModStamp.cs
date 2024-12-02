using HarmonyLib;
using UnityEngine;

namespace PhaserRole
{
    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class ModStamp
    {
        [HarmonyPostfix]
        public static void Postfix(PingTracker __instance)
        {
            var position = __instance.GetComponent<AspectPosition>();
                position.DistanceFromEdge = new Vector3(1.9f, 1f, 9.5f);
                position.AdjustPosition();

            __instance.aspectPosition.DistanceFromEdge = new Vector3(4f, 0.1f, -5);
            __instance.aspectPosition.Alignment = AspectPosition.EdgeAlignments.RightTop;
            __instance.text.outlineWidth = 0.3f;
            __instance.text.fontSize = 3f;
            __instance.text.text = "Made by <color=#429E9D>ConnorPlayz</color>\n" + "<color=#BEA4FFFF>Captain Mod v1.0</color>";
        }
    }
}