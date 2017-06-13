using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class StreamingAssetTEST : MonoBehaviour {

    Renderer rend;
    string url;
    MovieTexture movieTexture;
    AudioSource audioSource;
    private void Awake()
    {
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
        url = "file:///" + Application.streamingAssetsPath + "/Train.mp4";
    }

    void Start()
    {
        StartCoroutine(LoadMovie());
    }
    IEnumerator LoadMovie()
    {
        WWW www = new WWW(url);
        Debug.Log(url);
        movieTexture = www.movie;
        audioSource.clip = movieTexture.audioClip;

        while (!movieTexture.isReadyToPlay)
        {
            yield return null;
        }
        
        rend.material.mainTexture = movieTexture;

        movieTexture.Play();
        audioSource.Play();

    }
}



