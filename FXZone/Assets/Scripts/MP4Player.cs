using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MP4Player : MonoBehaviour // This is the script that controls the video player
{
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

    public static string directoryPath; // This string can be set by other scripts, this time it's set by "OpenFolder"

    public static bool randomize;
    public static bool colorFilter;


    void Start()

    {
        startPos = transform.position;
        startScale = transform.localScale;
        r = GetComponent<SpriteRenderer>(); // r will refer to the spriterenderer of the attached gameobject
        maxClips = Directory.GetFiles(directoryPath).Length; // maxClips will contain the number of files in the chosen directory
        i = 0;
        PlayClipNormal();
    }

    void FixedUpdate()
    {
        if (!randomize) { // If the user doesn't select the randomize option, it will call PlayClipNormal, else it will call PlayClipRandom
            if (videoClip.isPlaying == false) { // By checking videoClip.isPlaying we get an effective way to determine when the next clip needs to be played.
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

    void PlayClipRandom() { //
    // Set initial values...
        transform.position = startPos; 
        transform.localScale = startScale;
        rng = Random.Range(1,maxClips);
        videoClip = GetComponent<UnityEngine.Video.VideoPlayer>();
        r.color = new Color(1,1,1,1);
        videoClip.playbackSpeed = 1f;
        videoClip.frame = 0;
        videoClip.playOnAwake = false;
    //
        if (Directory.GetFiles(directoryPath)[rng].EndsWith(".mp4")) {  
            // since rng is a random number between 1 and maxClips (the number of files in the folder specified
            // in directoryPath), these lines of code will determine a random clip to play from the directory stored in
            // directoryPath, if it is a valid file type (EndsWith.mp4)
            videoClip.url = Directory.GetFiles(directoryPath)[rng];
            videoClip.Play();
        }
        if (colorFilter) { // If the colorFilter was enabled earlier, this will display it, but only the first time a clip is played
            if (firstplay) {
                window.SetRandomColor();
            }
            if (firstplay == false) { // 
                firstplay = true;
            }
        } else {
            window.gameObject.SetActive(false);
        }
    }

    void PlayClipNormal() { // Works basically the same way as PlayClipRandom, but uses i to determine which clip to play,
                            // thus playing the clips in the folder order since i incremits once each time a clip is played.
        transform.position = startPos;
        transform.localScale = startScale;
        videoClip = GetComponent<UnityEngine.Video.VideoPlayer>();
        r.color = new Color(1,1,1,1);
        videoClip.playbackSpeed = 1f;
        videoClip.frame = 0;
        videoClip.playOnAwake = false;
        if (Directory.GetFiles(directoryPath)[i].EndsWith(".mp4")) {
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
