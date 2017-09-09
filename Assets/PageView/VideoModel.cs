using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class VideoModel: MonoBehaviour
{
    public VideoData[] videoData;
    private string[] videoURLs;
    public int Count
    { get { return videoURLs.Length; } }



    private void Awake()
    {
        InitVideoData();
    }

    private void GetVideoURLs()
    {
        //string VideoPath = string.Format("{0}/CookTraining/Videos", Application.streamingAssetsPath);
        //videoURLs = Directory.GetFiles(VideoPath, "*mp4");
        videoURLs = Directory.GetFiles(Application.streamingAssetsPath, "*.jpg");
    }

    private void InitVideoData()
    {
        GetVideoURLs();
        videoData = new VideoData[Count];
        for (int i = 0; i < Count; ++i)
        {
            videoData[i] = new VideoData(Path.GetFileName(videoURLs[i]), videoURLs[i]);
            Debug.Log(videoData[i]);
        }
    }

}
