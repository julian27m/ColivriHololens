using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using MixedReality.Toolkit.SpatialManipulation;

public class RAMFilter : MonoBehaviour
{
    public ServerDataFetcher dataFetcher; // Aseg�rate de asignar la referencia a este script en el Inspector
    //private List<GameObject> activatedDesks = new List<GameObject>();
    public int indexHighestRAM = 0;
    public int indexLowestRAM = 0;
    public int indexHighestCPU = 0;
    public int indexLowestCPU = 0;
    public int indexHighestDisk = 0;
    public int indexLowestDisk = 0;
    public List<GameObject> Desk1;
    public List<GameObject> Desk2;
    public List<GameObject> Desk3;
    public List<GameObject> Desk4;
    public List<GameObject> Desk5;
    public List<GameObject> Desk6;
    public List<GameObject> Desk7;
    public List<GameObject> Desk8;
    public List<GameObject> Desk9;
    public List<GameObject> Desk10;
    public List<GameObject>Desk11;
    public List<GameObject> Desk12;
    public List<GameObject> Desk13;
    public List<GameObject> Desk14;
    public List<GameObject> Desk15;
    public List<GameObject> Desk16;
    public List<GameObject> Desk17;
    public List<GameObject> Desk18;
    public List<GameObject> Desk19;
    public List<GameObject> Desk20;
    public List<GameObject> Desk21;
    public List<GameObject> Desk22;
    public List<GameObject> Desk23;
    public List<GameObject> Desk24;
    public List<GameObject> Desk25;
    public List<GameObject> Desk26;
    

    void Start()
    {

    }

    public void HighRAMUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            //Debug.Log($"RAM Usage: {computerData.RAMUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del mayor uso de RAM en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsRAM(indexHighestRAM);
    }

    public void LowRAMUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"RAM Usage: {computerData.RAMUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del menor uso de RAM en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsRAM(indexLowestRAM);
    }

    public void HighCPUUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"CPU Usage: {computerData.CPUUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del mayor uso de CPU en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsCPU(indexHighestCPU);
    }

    public void LowCPUUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"CPU Usage: {computerData.CPUUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del menor uso de CPU en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsCPU(indexLowestCPU);
    }

    public void HighDiskUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"Disk Usage: {computerData.DiskUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del mayor uso de HDD en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsDisk(indexHighestDisk);
    }

    public void LowDiskUsage()
    {
        // Aseg�rate de tener datos antes de continuar
        if (dataFetcher == null || dataFetcher.computerDataList == null || dataFetcher.computerDataList.Count == 0)
        {
            Debug.LogWarning("No hay datos disponibles.");
            return;
        }

        // Log de toda la informaci�n en computerDataList
        foreach (var computerData in dataFetcher.computerDataList)
        {
            Debug.Log($"Disk Usage: {computerData.DiskUsage}");
            // Agrega m�s informaci�n seg�n las propiedades de tu clase ComputerData
        }

        // Encuentra el �ndice del menor uso de HDD en la lista
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

        // Activa los GameObjects correspondientes seg�n el �ndice encontrado
        ActivateAllDeskObjectsDisk(indexLowestDisk);
    }

    public void ActivateAllDeskObjectsRAM(int index)
    {
        List<GameObject> desk = GetDeskArray(index);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el primero (RAM) objeto en la lista
            if (i == 0)
            {
                // Almacena la informaci�n inicial del slate
                //Vector3 initialPosition = desk[i].transform.position;
                //Quaternion initialRotation = desk[i].transform.rotation;
                //Vector3 initialScale = desk[i].transform.localScale;

                GameObject newRam = Instantiate(desk[i]);

                desk.Add(newRam);

                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = newRam.GetComponent<RadialView>();


                // Verifica si se encontr� el componente antes de intentar activarlo
                if (radialView != null)
                {
                    // Activa el componente "Radial View"
                    radialView.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + newRam.name);
                }

                // Obtiene el componente "Object Manipulator" del primer objeto
                ObjectManipulator objectManipulator = newRam.GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + newRam.name);
                }
            }
        }
    }

    public void ActivateAllDeskObjectsCPU(int index)
    {
        List<GameObject> desk = GetDeskArray(index);
  

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
            {

                GameObject newCPU = Instantiate(desk[i]);
                desk.Add(newCPU);
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = newCPU.GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (radialView != null)
                {
                    // Activa el componente "Radial View"
                    radialView.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                // Obtiene el componente "Object Manipulator" del segundo objeto
                ObjectManipulator objectManipulator = newCPU.GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }

    public void ActivateAllDeskObjectsDisk(int index)
    {
        List<GameObject> desk = GetDeskArray(index);


        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Activa el objeto
            desk[i].SetActive(true);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
            {

                GameObject newDisk = Instantiate(desk[i]);
                desk.Add(newDisk);
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = newDisk.GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (radialView != null)
                {
                    // Activa el componente "Radial View"
                    radialView.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                // Obtiene el componente "Object Manipulator" del tercer objeto
                ObjectManipulator objectManipulator = newDisk.GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Activa el componente "Radial View"
                    objectManipulator.enabled = true;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
        }
    }



    public void DeactivateAllDeskObjectsHighRAM()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Highest: " + indexHighestRAM);
        List<GameObject> desk = GetDeskArray(indexHighestRAM);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el primer objeto en la lista
            if (i == 0)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if(i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    public void DeactivateAllDeskObjectsLowRAM()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Highest: " + indexLowestRAM);
        List<GameObject> desk = GetDeskArray(indexLowestRAM);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el primer objeto en la lista
            if (i == 0)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if (i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    public void DeactivateAllDeskObjectsHighCPU()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Highest CPU: " + indexHighestCPU);
        List<GameObject> desk = GetDeskArray(indexHighestCPU);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if (i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    public void DeactivateAllDeskObjectsLowCPU()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Highest: " + indexLowestCPU);
        List<GameObject> desk = GetDeskArray(indexLowestCPU);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el segundo (CPU) objeto en la lista
            if (i == 1)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if (i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    public void DeactivateAllDeskObjectsHighDisk()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Highest Disk: " + indexHighestDisk);
        List<GameObject> desk = GetDeskArray(indexHighestDisk);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if (i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    public void DeactivateAllDeskObjectsLowDisk()
    {
        // Desactiva todos los objetos usando el �ndice almacenado
        Debug.Log("Index Lowest: " + indexLowestDisk);
        List<GameObject> desk = GetDeskArray(indexLowestDisk);

        // Itera por cada objeto en la lista
        for (int i = 0; i < desk.Count; i++)
        {
            // Desactiva el objeto
            desk[i].SetActive(false);

            // Verifica si es el tercero (HDD) objeto en la lista
            if (i == 2)
            {
                // Obtiene el componente "Radial View" del primer objeto
                RadialView radialView = desk[i].GetComponent<RadialView>();

                // Verifica si se encontr� el componente antes de intentar desactivarlo
                if (radialView != null)
                {
                    // Desactiva el componente "Radial View"
                    radialView.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Radial View' en el objeto: " + desk[i].name);
                }

                ObjectManipulator objectManipulator = desk[i].GetComponent<ObjectManipulator>();

                // Verifica si se encontr� el componente antes de intentar activarlo
                if (objectManipulator != null)
                {
                    // Desactiva el componente "Object Manipulator"
                    objectManipulator.enabled = false;
                }
                else
                {
                    Debug.LogWarning("No se encontr� el componente 'Object Manipulator' en el objeto: " + desk[i].name);
                }
            }
            else if (i == 6)
            {
                desk.Remove(desk[i]);
            }
        }

    }

    private List<GameObject> GetDeskArray(int index)
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
            // Si el �ndice no coincide con ninguna lista existente, puedes agregar m�s casos seg�n sea necesario.
            // Por ahora, devuelve una lista vac�a.
            List<GameObject> deskList = new List<GameObject>();
            return deskList;
        }
    }
}
