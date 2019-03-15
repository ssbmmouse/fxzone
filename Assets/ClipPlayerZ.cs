using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipPlayerZ : MonoBehaviour
{
    // Start is called before the first frame update
    UnityEngine.Video.VideoPlayer videoClip;
    int rng;
    public int maxClips;
    public int frames;
    int mode;
    SpriteRenderer r;
    public Window window;
    Vector3 startPos;
    Vector3 startScale;
    bool firstplay;
    void Start()
    {
        startPos = transform.position;
        startScale = transform.localScale;
        r = GetComponent<SpriteRenderer>();
        PlayClip();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (videoClip.frame > frames) {
            PlayClip();
        }
        if (videoClip.frame > 0 && videoClip.frame < frames - 100) {
            if (r.color.a < 0.8f) {
                r.color = new Color(1,1,1,r.color.a + 0.01f);
            }
        }
        if (videoClip.frame > frames-100) {
            r.color = new Color(1,1,1,r.color.a - 0.01f);;
        }
        if (mode == 0) {
            transform.localScale = new Vector3(transform.localScale.x + 0.008f, transform.localScale.y + 0.0045f, transform.localScale.z);
        }
        if (mode == 1) {
            transform.position = new Vector3(transform.localPosition.x - 0.00025f, transform.localPosition.y, transform.localPosition.z);
        }
        if (mode == 3) {
            transform.localScale = new Vector3(24, 18, 1);
            transform.localScale = new Vector3(transform.localScale.x - 0.008f, transform.localScale.y - 0.0045f, transform.localScale.z);
        }
        if (mode == 4) {
            transform.position = new Vector3(transform.localPosition.x + 0.0005f, transform.localPosition.y, transform.localPosition.z);
        }
        if (mode == 5) {
            transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.0005f, transform.localPosition.z);
        }
        if (mode == 6) {
            transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.001f, transform.localPosition.z);
        }

    }

    void PlayClip() {
        mode = Random.Range(0,7);
        Debug.Log(mode);
        transform.position = startPos;
        transform.localScale = startScale;
        rng = Random.Range(1,maxClips);
        videoClip = GetComponent<UnityEngine.Video.VideoPlayer>();
        r.color = new Color(1,1,1,0);
        videoClip.playbackSpeed = Random.Range(0.5f,1f);
        videoClip.frame = 0;
        videoClip.playOnAwake = false;
        videoClip.url = "C:\\Users\\Drew\\Videos\\Runescape Footage\\mp4\\" + rng.ToString() + ".mp4";
        videoClip.Play();
        if (firstplay) {
            window.SetRandomColor();
        }
    
         if (firstplay == false) {
            firstplay = true;
        }
    }
    
}
