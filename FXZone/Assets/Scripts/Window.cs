using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    SpriteRenderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRandomColor() {
        r.color = new Color(Random.Range(0,0.5f),Random.Range(0,0.5f),Random.Range(0,0.5f),Random.Range(0.05f,0.2f));
    }
}
