using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static bool start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true){
            SceneManager.LoadScene(1);
        }
    }

    void OnMouseDown() {
        OpenFolder.Apply();
    }
}
