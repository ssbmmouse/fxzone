using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    SpriteRenderer r;

    void Start()
    {
        r = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    public void SetRandomColor() {  // Will randomly select a color filter to display over the video clip, to give it a sort of
                                    // "faded in the background" effect.
        r.color = new Color(Random.Range(0,0.5f),Random.Range(0,0.5f),Random.Range(0,0.5f),Random.Range(0.05f,0.2f));
    }
}
