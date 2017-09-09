using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewItemData : MonoBehaviour{

    public string title { get; set; }
    public string URL { get; set; }

    public ViewItemData(string title, string URL)
    {
        this.title = title;
        this.URL = URL;
    }

    public override string ToString()
    {
        return string.Format("ViewItemData: title is {0}, URL is {1}.", title, URL);
    }

}
