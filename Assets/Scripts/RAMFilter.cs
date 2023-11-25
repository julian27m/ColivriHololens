using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using MixedReality.Toolkit.SpatialManipulation;

public class RAMFilter : MonoBehaviour
{
    public ServerDataFetcher dataFetcher; // Asegúrate de asignar la referencia a este script en el Inspector
    public int indexHighestRAM = 0;
    public GameObject[] Desk1;
    public GameObject[] Desk21;

    void Start()
    {

    }

    public void HighRAMUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Encuentra el índice del mayor uso de RAM en la lista

        float highestRAM = float.MinValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            Type tipo = dataFetcher.computerDataList[i].RAMUsage.GetType();
            Debug.Log("Tipo de RAMUsage: " + tipo);
            string ramUsageString = dataFetcher.computerDataList[i].RAMUsage.Replace("%", "");
            float currentRAM = float.Parse(ramUsageString);

            if (currentRAM > highestRAM)
            {
                highestRAM = currentRAM;
                indexHighestRAM = i;
            }
        }

        Debug.Log("High: " + indexHighestRAM);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjects(indexHighestRAM);
    }

    public void ActivateAllDeskObjects(int index)
    {
        GameObject[] desk = GetDeskArray(index);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el primer objeto en la lista
            if (i == 0)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (radialView != null)
                {
                    // Activa el componente "Radial View"
                    radialView.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Radial View' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjects()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Highest: " + indexHighestRAM);
        GameObject[] desk = GetDeskArray(indexHighestRAM);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el primer objeto en la lista
            if (i == 0)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontró el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Radial View' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    private GameObject[] GetDeskArray(int index)
    {
        if (index == 0)
        {
            return Desk1;
        }
        else if (index == 20)
        {
            return Desk21;
        }
        else
        {
            // Si el índice no coincide con ninguna lista existente, puedes agregar más casos según sea necesario.
            // Por ahora, devuelve una lista vacía.
            return new GameObject[0];
        }
    }
}
