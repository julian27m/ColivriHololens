using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTargets : MonoBehaviour
{
    public GameObject[] Desks;
    public bool show = false;
    public GameObject showButton;
    public GameObject hideButton;
    public GameObject ramButton;
    public GameObject cpuButton;
    public GameObject diskButton;
    public GameObject dataButton;
    public GameObject backButton;

    void Start()
    {
        
    }

    public void showTargets()
    {
        showButton.SetActive(false);
        hideButton.SetActive(true);
        show = true;
        for (int i = 0; i < Desks.Length; i++)
        {
            // Activa el objeto
            Desks[i].SetActive(true);
        }
    }

    public void hideTargets()
    {
        hideButton.SetActive(false);
        showButton.SetActive(true);
        show = false;
        for (int i = 0; i < Desks.Length; i++)
        {
            // Activa el objeto
            Desks[i].SetActive(false);
        }
    }

    public void hideTargets2()
    {
        hideButton.SetActive(false);
        show = false;
        for (int i = 0; i < Desks.Length; i++)
        {
            // Activa el objeto
            Desks[i].SetActive(false);
        }
    }

    public void back()
    {
        if (show == true)
        {
            dataButton.SetActive(true);
            hideButton.SetActive(true);
            ramButton.SetActive(false);
            cpuButton.SetActive(false);
            diskButton.SetActive(false);
            showButton.SetActive(false);
            backButton.SetActive(false);
        }
        else if (show == false)
        {
            dataButton.SetActive(true);
            showButton.SetActive(true);
            ramButton.SetActive(false);
            cpuButton.SetActive(false);
            diskButton.SetActive(false);
            hideButton.SetActive(false);
            backButton.SetActive(false);
        }

    }

    }
