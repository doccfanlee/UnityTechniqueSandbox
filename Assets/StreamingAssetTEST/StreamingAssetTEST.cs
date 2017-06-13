using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class StreamingAssetTEST : MonoBehaviour {

    Renderer rend;
    string url;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        url = "file:///" + Application.streamingAssetsPath + "/EnvMov.mp4";
        Debug.Log(url);
    }
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        MovieTexture movieTexture = www.movie;
        while (!movieTexture.isReadyToPlay)
        {
            yield return null;
        }
        
        rend.material.mainTexture = movieTexture;

        movieTexture.Play();

    }
}



