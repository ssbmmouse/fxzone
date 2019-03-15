using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFilterToggle : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MP4Player.colorFilter == false) {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (MP4Player.colorFilter == true) {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    void OnMouseDown()
    {
        if (MP4Player.colorFilter == false) {
            MP4Player.colorFilter = true;
        } else if (MP4Player.colorFilter == true) {
            MP4Player.colorFilter = false;
        }
    }
}
