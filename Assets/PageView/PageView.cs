using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageView : MonoBehaviour
{

    public GameObject videoItemPrefab;

    public void AddItem(string name, string URL)
    {
        GameObject newItem = Instantiate(videoItemPrefab, transform);
        ViewItemData newViewItemData = newItem.AddComponent<ViewItemData>();
        newViewItemData.title = name;
        newViewItemData.URL = string.Format("file://{0}", URL);

        // Sync Text.text with ViewItemData.title
        newItem.GetComponentInChildren<Text>().text = newViewItemData.title;
        // Apply image and the width 340 and height 220 are hardcoded
        // If want to use Sprite, try Sprite.Create()
        Texture2D tex;
        tex = new Texture2D(340, 220, TextureFormat.DXT1, false);
        WWW www = new WWW(newViewItemData.URL);
        www.LoadImageIntoTexture(tex);
        newItem.GetComponentInChildren<RawImage>().texture = tex;
    }

    public void CleanPage()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
