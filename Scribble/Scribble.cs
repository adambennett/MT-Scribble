using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Scribble
{
    [BepInPlugin("nyoxide.monstertrain.scribble", "Scribble", "1.0.0.0")]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("api.modding.train.monster")]
    public class Scribbler : BaseUnityPlugin
    {
        private static ManualLogSource logger = BepInEx.Logging.Logger.CreateLogSource("Scribble");
        
        public static void log(LogLevel lvl, string msg)
        {
            logger.Log(lvl, msg);
        }
        
        void Awake()
        {
            var harmony = new Harmony("nyoxide.monstertrain.harmony");
            harmony.PatchAll();
        }
        
    }
}