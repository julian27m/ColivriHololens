using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

[System.Serializable]
public class ComputerDynamicData
{
    public string CPUUsage;
    public string RAMUsage;
    public string DiskUsage;
}

public class ServerDataFetcher : MonoBehaviour
{
    public TextMeshPro cpuTextMesh; // Reference to your TextMeshPro object for CPU
    public TextMeshPro ramTextMesh; // Reference to your TextMeshPro object for RAM
    public TextMeshPro diskTextMesh; // Reference to your TextMeshPro object for Disk

    //public TextMeshPro cpuTextMesh2; // Reference to your TextMeshPro object for CPU
    //public TextMeshPro ramTextMesh2; // Reference to your TextMeshPro object for RAM
    //public TextMeshPro diskTextMesh2; // Reference to your TextMeshPro object for Disk

    void Start()
    {
        StartCoroutine(FetchData());
    }

    IEnumerator FetchData()
    {
        while (true) // Continuously fetch data
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get("http://157.253.192.187:8000/data"))
            {
                yield return webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.Success)
                {
                    string jsonData = webRequest.downloadHandler.text;

                    // Parse the JSON data into a ComputerDynamicData object
                    ComputerDynamicData computerData = JsonUtility.FromJson<ComputerDynamicData>(jsonData);

                    // Update your TextMeshPro objects with the parsed data
                    cpuTextMesh.text = "Uso actual: " + computerData.CPUUsage;
                    //Debug.Log("Uso actual CPU: " + computerData.CPUUsage);
                    ramTextMesh.text = "Uso actual: " + computerData.RAMUsage;
                    //Debug.Log("Uso actual RAM: " + computerData.RAMUsage);
                    diskTextMesh.text = "Uso actual: " + computerData.DiskUsage;
                    //Debug.Log("Uso actual dsico: " + computerData.DiskUsage);

                    // Update your TextMeshPro objects with the parsed data
                    //cpuTextMesh2.text = "Uso actual: " + computerData.CPUUsage;
                    //Debug.Log("Uso actual CPU: " + computerData.CPUUsage);
                    //ramTextMesh2.text = "Uso actual: " + computerData.RAMUsage;
                    //Debug.Log("Uso actual RAM: " + computerData.RAMUsage);
                    //diskTextMesh2.text = "Uso actual: " + computerData.DiskUsage;
                    //Debug.Log("Uso actual dsico: " + computerData.DiskUsage);
                }
                else
                {
                    Debug.LogError("Error fetching data: " + webRequest.error);
                }
            }

            yield return new WaitForSeconds(5f); // Adjust the refresh rate as needed
        }
    }
}
