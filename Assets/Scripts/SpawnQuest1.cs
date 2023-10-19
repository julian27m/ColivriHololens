using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnQuest1 : MonoBehaviour
{
    public GameObject objectToSpawn; // El GameObject que deseas activar o desactivar

    private string serverURL = "http://18.188.1.225:8080/data/holop";

    void Start()
    {
        StartCoroutine(GetCameraPositionFromServer());
    }

    IEnumerator GetCameraPositionFromServer()
    {
        UnityWebRequest request = UnityWebRequest.Get(serverURL);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            // Analiza el JSON para obtener la posición
            string json = request.downloadHandler.text;
            CameraPositionGet position = JsonUtility.FromJson<CameraPositionGet>(json);

            float xPos = position.camX;
            float yPos = position.camY;
            float zPos = position.camZ;

            // Comprueba si la posición es x=0, y=0, z=0
            if (xPos == 0f && yPos == 0f && zPos == 0f)
            {
                // La posición es (0, 0, 0), desactiva el objeto
                objectToSpawn.SetActive(false);
            }
            else
            {
                // La posición no es (0, 0, 0), activa el objeto y establece su posición
                objectToSpawn.SetActive(true);
                objectToSpawn.transform.position = new Vector3(xPos, yPos, zPos);
            }
        }
        else
        {
            Debug.LogError("Error fetching camera position: " + request.error);
        }
    }
}

[System.Serializable]
public class CameraPositionGet
{
    public float camX; // Cambiado de x a camX
    public float camY; // Cambiado de y a camY
    public float camZ; // Cambiado de z a camZ
}
