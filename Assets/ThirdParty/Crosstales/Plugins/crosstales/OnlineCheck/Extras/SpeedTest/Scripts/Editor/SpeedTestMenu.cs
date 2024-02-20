﻿#if UNITY_EDITOR
using UnityEditor;
using Crosstales.OnlineCheck.EditorUtil;
using Crosstales.OnlineCheck.Util;

namespace Crosstales.OnlineCheck.EditorIntegration
{
   /// <summary>Editor component for the "Tools"-menu.</summary>
   public static class SpeedTestMenu
   {
      [MenuItem("Tools/" + Constants.ASSET_NAME + "/Prefabs/" + Constants.SPEEDTEST_SCENE_OBJECT_NAME, false, EditorHelper.MENU_ID + 80)]
      private static void AddSpeedTest()
      {
         EditorHelper.InstantiatePrefab(Constants.SPEEDTEST_SCENE_OBJECT_NAME, $"{EditorConfig.ASSET_PATH}Extras/SpeedTest/Resources/Prefabs/");
      }

      [MenuItem("Tools/" + Constants.ASSET_NAME + "/Prefabs/" + Constants.SPEEDTEST_SCENE_OBJECT_NAME, true)]
      private static bool AddSpeedTestValidator()
      {
         return !EditorHelper.isSpeedTestInScene;
      }
   }
}
#endif
// © 2021-2023 crosstales LLC (https://www.crosstales.com)