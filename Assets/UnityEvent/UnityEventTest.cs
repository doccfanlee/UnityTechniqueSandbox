using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UnityEventTest : MonoBehaviour, IPointerEnterHandler {

	// Use this for initialization
	//void Start () 
 //   {
	//	GetComponent<Button>().onClick.AddListener(() => TestScript());


 
	//}

	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log("Pointer Entered!");
	}

    void TestScript()
    {
        Debug.Log("Button Clicked!");
    }
}
