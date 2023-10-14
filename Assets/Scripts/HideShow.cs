using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShow : MonoBehaviour
{
    public GameObject currentSlate;
    public void show()
    {
        if (currentSlate != null)
        {
            //Debug.Log("Gaze: " + gazeSlate);
            currentSlate.SetActive(true);
        }
        else
        {
            //Debug.Log("Show: " + "No lo reconoce");
        }
    }

    public void hide()
    {
        if (currentSlate != null)
        {
            currentSlate.SetActive(false);
        }


    }
}
