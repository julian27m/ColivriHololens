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
    public int indexLowestRAM = 0;
    public int indexHighestCPU = 0;
    public int indexLowestCPU = 0;
    public int indexHighestDisk = 0;
    public int indexLowestDisk = 0;
    public GameObject[] Desk1;
    public GameObject[] Desk2;
    public GameObject[] Desk3;
    public GameObject[] Desk4;
    public GameObject[] Desk5;
    public GameObject[] Desk6;
    public GameObject[] Desk7;
    public GameObject[] Desk8;
    public GameObject[] Desk9;
    public GameObject[] Desk10;
    public GameObject[] Desk11;
    public GameObject[] Desk12;
    public GameObject[] Desk13;
    public GameObject[] Desk14;
    public GameObject[] Desk15;
    public GameObject[] Desk16;
    public GameObject[] Desk17;
    public GameObject[] Desk18;
    public GameObject[] Desk19;
    public GameObject[] Desk20;
    public GameObject[] Desk21;
    public GameObject[] Desk22;
    public GameObject[] Desk23;
    public GameObject[] Desk24;
    public GameObject[] Desk25;
    public GameObject[] Desk26;
    

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

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            //Debug.Log($"RAM Usage: {computerData.RAMUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del mayor uso de RAM en la lista
        float highestRAM = float.MinValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
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
        ActivateAllDeskObjectsRAM(indexHighestRAM);
    }

    public void LowRAMUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"RAM Usage: {computerData.RAMUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del menor uso de RAM en la lista
        float lowestRAM = float.MaxValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            string ramUsageString = dataFetcher.computerDataList[i].RAMUsage.Replace("%", "");
            float currentRAM = float.Parse(ramUsageString);

            if (currentRAM < lowestRAM)
            {
                lowestRAM = currentRAM;
                indexLowestRAM = i;
            }
        }

        Debug.Log("Low: " + indexLowestRAM);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjectsRAM(indexLowestRAM);
    }

    public void HighCPUUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"CPU Usage: {computerData.CPUUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del mayor uso de CPU en la lista
        float highestCPU = float.MinValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            string cpuUsageString = dataFetcher.computerDataList[i].CPUUsage.Replace("%", "");
            float currentCPU = float.Parse(cpuUsageString);

            if (currentCPU > highestCPU)
            {
                highestCPU = currentCPU;
                indexHighestCPU = i;
            }
        }

        Debug.Log("High CPU: " + indexHighestCPU);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjectsCPU(indexHighestCPU);
    }

    public void LowCPUUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"CPU Usage: {computerData.CPUUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del menor uso de CPU en la lista
        float lowestCPU = float.MaxValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            string cpuUsageString = dataFetcher.computerDataList[i].CPUUsage.Replace("%", "");
            float currentCPU = float.Parse(cpuUsageString);

            if (currentCPU < lowestCPU)
            {
                lowestCPU = currentCPU;
                indexLowestCPU = i;
            }
        }

        Debug.Log("Low CPU: " + indexLowestCPU);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjectsCPU(indexLowestCPU);
    }

    public void HighDiskUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"Disk Usage: {computerData.DiskUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del mayor uso de HDD en la lista
        float highestDisk = float.MinValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            string diskUsageString = dataFetcher.computerDataList[i].DiskUsage.Replace("%", "");
            float currentDisk = float.Parse(diskUsageString);

            if (currentDisk > highestDisk)
            {
                highestDisk = currentDisk;
                indexHighestDisk = i;
            }
        }

        Debug.Log("High Disk: " + indexHighestDisk);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjectsDisk(indexHighestDisk);
    }

    public void LowDiskUsage()
    {
        // Asegúrate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la información en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"Disk Usage: {computerData.DiskUsage}");
            // Agrega más información según las propiedades de tu clase ComputerData
        }

        // Encuentra el índice del menor uso de HDD en la lista
        float lowestDisk = float.MaxValue;

        for (int i = 0; i < dataFetcher.computerDataList.Count; i++)
        {
            string diskUsageString = dataFetcher.computerDataList[i].DiskUsage.Replace("%", "");
            float currentDisk = float.Parse(diskUsageString);

            if (currentDisk < lowestDisk)
            {
                lowestDisk = currentDisk;
                indexLowestDisk = i;
            }
        }

        Debug.Log("Low Disk: " + indexLowestDisk);

        // Activa los GameObjects correspondientes según el índice encontrado
        ActivateAllDeskObjectsDisk(indexLowestDisk);
    }

    public void ActivateAllDeskObjectsRAM(int index)
    {
        GameObject[] desk = GetDeskArray(index);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el segundo (CPU) objeto en la lista
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

                // Obtiene el componente "Object Manipulator" del primer objeto
                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void ActivateAllDeskObjectsCPU(int index)
    {
        GameObject[] desk = GetDeskArray(index);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
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

                // Obtiene el componente "Object Manipulator" del segundo objeto
                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void ActivateAllDeskObjectsDisk(int index)
    {
        GameObject[] desk = GetDeskArray(index);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
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

                // Obtiene el componente "Object Manipulator" del tercer objeto
                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsHighRAM()
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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsLowRAM()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Highest: " + indexLowestRAM);
        GameObject[] desk = GetDeskArray(indexLowestRAM);

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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsHighCPU()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Highest CPU: " + indexHighestCPU);
        GameObject[] desk = GetDeskArray(indexHighestCPU);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsLowCPU()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Highest: " + indexLowestCPU);
        GameObject[] desk = GetDeskArray(indexLowestCPU);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsHighDisk()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Highest Disk: " + indexHighestDisk);
        GameObject[] desk = GetDeskArray(indexHighestDisk);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void DeactivateAllDeskObjectsLowDisk()
    {
        // Desactiva todos los objetos usando el índice almacenado
        Debug.Log("Index Lowest: " + indexLowestDisk);
        GameObject[] desk = GetDeskArray(indexLowestDisk);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Length; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
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

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontró el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontró el componente 'Object Manipulator' en el objeto: " + desk[i].name);
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
        else if (index == 1)
        {
            return Desk2;
        }
        else if (index == 2)
        {
            return Desk3;
        }
        else if (index == 3)
        {
            return Desk4;
        }
        else if (index == 4)
        {
            return Desk5;
        }
        else if (index == 5)
        {
            return Desk6;
        }
        else if (index == 6)
        {
            return Desk7;
        }
        else if (index == 7)
        {
            return Desk8;
        }
        else if (index == 8)
        {
            return Desk9;
        }
        else if (index == 9)
        {
            return Desk10;
        }
        else if (index == 10)
        {
            return Desk11;
        }
        else if (index == 11)
        {
            return Desk12;
        }
        else if (index == 12)
        {
            return Desk13;
        }
        else if (index == 13)
        {
            return Desk14;
        }
        else if (index == 14)
        {
            return Desk15;
        }
        else if (index == 15)
        {
            return Desk16;
        }
        else if (index == 16)
        {
            return Desk17;
        }
        else if (index == 17)
        {
            return Desk18;
        }
        else if (index == 18)
        {
            return Desk19;
        }
        else if (index == 19)
        {
            return Desk20;
        }
        else if (index == 20)
        {
            return Desk21;
        }
        else if (index == 21)
        {
            return Desk22;
        }
        else if (index == 22)
        {
            return Desk23;
        }
        else if (index == 23)
        {
            return Desk24;
        }
        else if (index == 24)
        {
            return Desk25;
        }
        else if (index == 25)
        {
            return Desk26;
        }
        else
        {
            // Si el índice no coincide con ninguna lista existente, puedes agregar más casos según sea necesario.
            // Por ahora, devuelve una lista vacía.
            return new GameObject[0];
        }
    }
}
