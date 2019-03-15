
using System.IO;
using UnityEditor;


public class OpenFolder : EditorWindow
{
    [MenuItem("Assets/Clips")]
    public static void Apply() {
        MP4Player.directoryPath = EditorUtility.OpenFolderPanel("Select Video Clip Directory","","");
        Manager.start = true;
    }

}
