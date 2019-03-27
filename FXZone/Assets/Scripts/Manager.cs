using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static bool start;

    void Start()
    {
        
    }

    void Update()
    {
        if (start == true) {    // Once the bool "start" becomes true, this will immediately change the scene
                                // The next scene will be the video player, so this basically starts the program
            SceneManager.LoadScene(1);
        }
    }

    void OnMouseDown() {
        OpenFolder.Apply();
    }
}
