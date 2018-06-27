using Harmony;
using nl.flukeyfiddler.bt.BTModTemplate.Utils;
using nl.flukeyfiddler.bt.Utils.Logger;
using System.IO;
using System.Reflection;

namespace nl.flukeyfiddler.bt.BTModTemplate
{
    public class BTModTemplate
    {
        public static void Init(string modDirectory, string settingsJSON)
        {
            var harmony = HarmonyInstance.Create("nl.flukeyfiddler.bt.
            harmony.PatchAll(Assembly.GetExecutingAssembly());


            Logger.SetLogFilePath(new LogFilePath(Path.Combine(modDirectory, "Log.txt")));
            Logger.GameStarted();
        }
    }
}
