using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageController : MonoBehaviour
{
    public VideoModel videoModel;
    public PageView pageView;

    private const int ItemNumberOnePage = 9;
    private int currentPageNumber;

    private int CurrentPageNumber
    {
       // get { return Mathf.Clamp(currentPageNumber, 1, MaxPageNumber); }
        get { return currentPageNumber; }
        set
        {
           currentPageNumber = Mathf.Clamp(value, 1, MaxPageNumber);
        }
    }
    private int DataCount
    {
        get { return videoModel.Count; }
    }

    private int MaxPageNumber
    {
        get
        {
            if (DataCount % ItemNumberOnePage == 0)
                return DataCount / ItemNumberOnePage;
            else
                return DataCount / ItemNumberOnePage + 1;
        }
    }

    private void Start()
    {
        currentPageNumber = 1;
        ShowCurrentPageView();
    }
    private void ShowCurrentPageView()
    {
        pageView.CleanPage();

        int begin = ItemNumberOnePage * (CurrentPageNumber - 1);
        int end = Mathf.Min(ItemNumberOnePage * CurrentPageNumber, DataCount);
        for (int i = begin; i < end; i++)
        {
            pageView.AddItem(videoModel.videoData[i].name, videoModel.videoData[i].URL);
        }

    }


    public void NextPage()
    {
        if (CurrentPageNumber == MaxPageNumber)
            return;
        
        CurrentPageNumber++;
        ShowCurrentPageView();
    }

    public void PrevPage()
    {
        if (CurrentPageNumber == 1)
            return;
        
        CurrentPageNumber--;
        ShowCurrentPageView();
    }
}
