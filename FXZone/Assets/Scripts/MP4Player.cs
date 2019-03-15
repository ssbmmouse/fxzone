using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MP4Player : MonoBehaviour
{
    // Start is called before the first frame update
    UnityEngine.Video.VideoPlayer videoClip;

    SpriteRenderer r;

    Vector3 startPos;
    Vector3 startScale;

    int rng;
    int maxClips;
    int mode;
    int i;

 
    public Window window;

    bool firstplay;

    public static string directoryPath;

    public static bool randomize;
    public static bool colorFilter;


    void Start()

    {
        startPos = transform.position;
        startScale = transform.localScale;
        r = GetComponent<SpriteRenderer>();
        maxClips = Directory.GetFiles(directoryPath).Length;
        i = 0;
        PlayClipNormal();
    }

    void FixedUpdate()
    {
        if (!randomize) {
            if (videoClip.isPlaying == false) {
                i += 1;
                Debug.Log("Playing Next Clip" + i.ToString());
                if (i < maxClips) {
                    PlayClipNormal();
                }
            }
        } else {
            if (videoClip.isPlaying == false) {
                Debug.Log("Playing Next Clip");
                PlayClipRandom();
            }
        }
        
    }

    void PlayClipRandom() {
        transform.position = startPos;
        transform.localScale = startScale;
        rng = Random.Range(1,maxClips);
        videoClip = GetComponent<UnityEngine.Video.VideoPlayer>();
        r.color = new Color(1,1,1,1);
        videoClip.playbackSpeed = 1f;
        videoClip.frame = 0;
        videoClip.playOnAwake = false;
        if (Directory.GetFiles(directoryPath)[rng].EndsWith(".mp4")) {
            videoClip.url = Directory.GetFiles(directoryPath)[rng];
            videoClip.Play();
        }
        if (colorFilter) {
            if (firstplay) {
                window.SetRandomColor();
            }
            if (firstplay == false) {
                firstplay = true;
            }
        } else {
            window.gameObject.SetActive(false);
        }
    }

    void PlayClipNormal() {
        transform.position = startPos;
        transform.localScale = startScale;
        videoClip = GetComponent<UnityEngine.Video.VideoPlayer>();
        r.color = new Color(1,1,1,1);
        videoClip.playbackSpeed = 1f;
        videoClip.frame = 0;
        videoClip.playOnAwake = false;
        if (Directory.GetFiles(directoryPath)[rng].EndsWith(".mp4")) {
            videoClip.url = Directory.GetFiles(directoryPath)[i];
            Debug.Log(videoClip.url);
            videoClip.Play();
        }
        if (colorFilter) {
            if (firstplay) {
                window.SetRandomColor();
            }
            if (firstplay == false) {
                firstplay = true;
            }
        } else {
            window.gameObject.SetActive(false);
        }
    }
    
}
