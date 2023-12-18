using BepInEx;
using BepInEx.Logging;
using Complex_Uni.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Uni
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Complex_Uni : BaseUnityPlugin
    {
        private const string modGUID = "Complex.Uni";
        private const string modName = "ComplexUni: a Multiplayer OverHaul";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Complex_Uni Instance;

        internal ManualLogSource mls;


        void Awake()
        {
            if (Instance == null) 
            {
                Instance = this;
         }
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The Test Mod has awakened :)");

            harmony.PatchAll(typeof(Complex_Uni));
            harmony.PatchAll(typeof(PlayerControllerBPatch));

        }




    }
}
