using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFilterToggle : MonoBehaviour  // Determines whether the user has enabled the color filter, and 
                                                // displays green if it is or red if not
{
    void Start()
    {
        
    }

    void Update()
    {
        if (MP4Player.colorFilter == false) { 
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (MP4Player.colorFilter == true) {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    void OnMouseDown() // This changes the current state of the color filter toggle on a mouseclick on the attached game object
    {
        if (MP4Player.colorFilter == false) {
            MP4Player.colorFilter = true;
        } else if (MP4Player.colorFilter == true) {
            MP4Player.colorFilter = false;
        }
    }
}
