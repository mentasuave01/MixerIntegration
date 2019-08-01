using IPA;
using IPA.Config;
using IPA.Utilities;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace MixerIntegration
{
    public class Plugin : IBeatSaberPlugin
    {
        public static readonly string ModuleName = "MixerSaber";
        public string Name => ModuleName;
        public string Version => "1.0.0";

        public static Plugin Instance { get; private set; }

        public void Init(object ignored, IPALogger logger)
        {
            Logger.log = logger;
        }

        public void OnApplicationStart()
        {
            Logger.log.Debug("OnApplicationStart");
        }

        public void OnApplicationQuit()
        {
            Logger.log.Debug("OnApplicationQuit");
        }

        public void OnFixedUpdate()
        {

        }

        public void OnUpdate()
        {

        }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {

        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {

        }

        public void OnSceneUnloaded(Scene scene)
        {

        }
    }
}
