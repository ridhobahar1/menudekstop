using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public class MyEditorScript : MonoBehaviour
{
    
    /*static void PerformBuild ()
     {
        string[] defaultScenes = { "Assets/Scenes/SampleScene.unity" };
         BuildPipeline.BuildPlayer(defaultScenes,"./builds/",
         BuildTarget.Android);
     }*/

    Debug.Log([MenuItem("Assets/Build")]);
    
    public static void PerformBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity"};
        buildPlayerOptions.locationPathName = "Build";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }
    }

     
}
