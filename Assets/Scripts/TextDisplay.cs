using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextDisplay : MonoBehaviour
{
    public Canvas textCanvas;
    public Text textElement;

    private void Start()
    {
        // Disable the canvas initially
        textCanvas.gameObject.SetActive(false);
    }

    public void ShowText(string message)
    {
        // Set the text content
        textElement.text = message;

        // Enable the canvas
        textCanvas.gameObject.SetActive(true);
    }

    public void HideText()
    {
        // Disable the canvas
        textCanvas.gameObject.SetActive(false);
    }
}
