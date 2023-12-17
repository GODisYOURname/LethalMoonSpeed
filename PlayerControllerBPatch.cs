using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SunicMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void infiniteSprintPatch(ref float ___sprintMeter, ref float ___sprintMultiplier, ref float ___jumpForce, ref bool ___isFallingFromJump, ref bool ___isFallingNoJump, ref bool ___isSprinting, ref bool ___takingFallDamage) 
        { 
            ___sprintMeter = 1f;
            ___jumpForce = 100f;
            ___takingFallDamage = false;
            ___isFallingFromJump = false;
            ___isFallingNoJump = false;


            if (___isSprinting == true)
            {
                ___sprintMultiplier = 20f;
                 
            }  

        }
        static void ChackingFingerPatch(ref float ___limpMultiplier)
        {
            ___limpMultiplier = 100f;
        }
    }
}
