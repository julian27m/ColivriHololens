using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlateManager : MonoBehaviour
{
    public GameObject currentSlate; // Reference to the current slate GameObject
    public GameObject nextSlate;    // Reference to the next slate GameObject
    public GameObject newSlate;    // Reference to the new slate GameObject
    public GameObject homeSlate;    // Reference to the home slate GameObject
    public GameObject gazeSlate;    // Reference to the gaze slate GameObject

    public void ShowNextSlate()
    {
        if (currentSlate != null)
        {
            currentSlate.SetActive(false);
        }

        if (nextSlate != null)
        {
            nextSlate.SetActive(true);
        }
    }
    public void GoBackMenu()
    {
        if (currentSlate != null)
        {
            newSlate.SetActive(false);
        }

        if (nextSlate != null)
        {
            homeSlate.SetActive(true);
        }
    }

    public void ShowSlateGaze()
    {

        if (gazeSlate != null)
        {
            //Debug.Log("Gaze: " + gazeSlate);
            gazeSlate.SetActive(true);
        }
        else{
            //Debug.Log("Gaze: " + "No lo reconoce");
        }
    }

    public void HideSlateGaze()
    {
        if (gazeSlate != null)
        {
            gazeSlate.SetActive(false);
        }


    }

}

