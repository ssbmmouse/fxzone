
using System.IO;
using UnityEditor;


public class OpenFolder : EditorWindow
{
    [MenuItem("Assets/Clips")]
    public static void Apply() { // Opens the Windows Folder Panel so the user can select a folder with mp4s, then sets start to true (in manager) and starts the program
        MP4Player.directoryPath = EditorUtility.OpenFolderPanel("Select Video Clip Directory","","");
        Manager.start = true;
    }

}
