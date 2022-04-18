using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerManager : MonoBehaviour
{
    public LevelLoader levelLoader;
    public VideoPlayer introVideo;
    private bool videoEndReached = false;
    private void Start()
    {

    }
    private void Update()
    {

        introVideo.loopPointReached += EndReached;
    }
    void EndReached(VideoPlayer videoPlayer)
    {
        if (!videoEndReached)
        {
            print("Video ended");
            levelLoader.LoadLevel(1);
            videoEndReached = true;
        }
    }
}
