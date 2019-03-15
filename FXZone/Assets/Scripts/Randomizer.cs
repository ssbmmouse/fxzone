using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MP4Player.randomize == false) {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (MP4Player.randomize == true) {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    void OnMouseDown()
    {
        if (MP4Player.randomize == false) {
            MP4Player.randomize = true;
        } else if (MP4Player.randomize == true) {
            MP4Player.randomize = false;
        }
    }
}
