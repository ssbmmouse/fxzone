using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour // Enables or disables the randomize feature and displays to the user whether or not it is enabled
{
    
    void Start()
    {
        
    }

    void Update()
    {
        // Will show as red if disabled and green if enabled
        if (MP4Player.randomize == false) { 
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (MP4Player.randomize == true) {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    void OnMouseDown() // Clicking on the gameobject this is attached to will change the setting of whether to randomize or not
    {
        if (MP4Player.randomize == false) {
            MP4Player.randomize = true;
        } else if (MP4Player.randomize == true) {
            MP4Player.randomize = false;
        }
    }
}
