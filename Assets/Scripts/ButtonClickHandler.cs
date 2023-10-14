using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject currentButton;
    public GameObject newButton;
    public void change()
    {
        if (currentButton != null)
        {
            currentButton.SetActive(false);
            newButton.SetActive(true);
        }
        else
        {
            //Debug.Log("Button: " + "No lo reconoce");
        }
    }

    public void back()
    {
        if (newButton != null)
        {
            newButton.SetActive(false);
            currentButton.SetActive(true);

        }
        else
        {
            //Debug.Log("ButtonBack: " + "No lo reconoce");
        }
    }
}
