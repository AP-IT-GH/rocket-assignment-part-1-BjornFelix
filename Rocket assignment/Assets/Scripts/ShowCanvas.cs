using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{

    public static Canvas CanvasObject;

    void Start()
    {
        CanvasObject = GameObject.Find("GameOverCanvas").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

    public static void ShowScreen()
    {


        CanvasObject.GetComponent<Canvas>().enabled = true;
        
        
    }

    public static void HideScreen()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

}
