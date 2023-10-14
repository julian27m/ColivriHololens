using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Material gazeMaterial; // The material to apply when gazed at

    private Material originalMaterial; // The original material of the object
    private Renderer objectRenderer;
    private bool isGazeHovered = false;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    private void Update()
    {
        if (isGazeHovered)
        {
            // Change the material to the gazeMaterial when gazed at
            objectRenderer.material = gazeMaterial;
        }
        else
        {
            // Reset the material to the originalMaterial when gaze exits
            objectRenderer.material = originalMaterial;
        }
    }

    // Called when the object is gazed at (IsGazeHovered On Entered event)
    public void Increment()
    {
        isGazeHovered = true;
    }

    // Called when the gaze exits the object (IsGazeHovered On Exited event)
    public void Decrement()
    {
        isGazeHovered = false;
    }
}
