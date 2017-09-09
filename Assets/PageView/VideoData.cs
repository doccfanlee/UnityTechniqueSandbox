using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoData
{
    public string name
    {
        get; set;
    }
    public string URL
    {
        get; set;
    }

    public VideoData(string name, string URL)
    {
        this.name = name;
        this.URL = URL;
    }

    public override string ToString()
    {
        return string.Format("name is {0}, URL is {1}.", name, URL);
    }

}
