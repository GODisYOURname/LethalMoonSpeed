using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SunicMod.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunicMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class SunicModBase : BaseUnityPlugin
    {
        private const string modGUID = "Poseidon.SunicMod";
        private const string modName = "Sunic Mod";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static SunicModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("This test has awake :) ");

            harmony.PatchAll(typeof(SunicModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));           
        }

        
    }
}
