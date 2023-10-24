using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class CameraPosition
{
    public float x;
    public float y;
    public float z;
}

public class CameraPositionSender : MonoBehaviour
{
    private string serverURL = "http://18.188.1.225:8080/data/holop";
    public float updateInterval = 3f; // Intervalo de actualización en segundos

    private bool isApplicationPaused = false;

    private void Start()
    {
        // Inicia la actualización periódica
        InvokeRepeating("SendCameraPosition", 0f, updateInterval);
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        isApplicationPaused = pauseStatus;

        if (isApplicationPaused)
        {
            // La aplicación está en pausa o en segundo plano
            // Envía un JSON con posición nula al servidor
            CameraPosition nullPosition = new CameraPosition
            {
                x = 1000f,
                y = 1000f,
                z = 1000f
            };
            string nullPositionJSON = JsonUtility.ToJson(nullPosition);

            StartCoroutine(SendPositionToServer(nullPositionJSON));
        }
    }

    private void OnApplicationQuit()
    {
        // La aplicación se está cerrando
        // Envía un JSON con posición nula al servidor antes de cerrar la aplicación
        CameraPosition nullPosition = new CameraPosition
        {
            x = 1000f,
            y = 1000f,
            z = 1000f
        };
        string nullPositionJSON = JsonUtility.ToJson(nullPosition);

        StartCoroutine(SendPositionToServer(nullPositionJSON));
    }

    void SendCameraPosition()
    {
        if (!isApplicationPaused)
        {
            // La aplicación no está en pausa o en segundo plano
            // Obtén la posición de la cámara principal
            Vector3 cameraPosition = Camera.main.transform.position;

            // Crea un objeto CameraPosition y asigna la posición
            CameraPosition position = new CameraPosition
            {
                x = cameraPosition.x,
                y = cameraPosition.y,
                z = cameraPosition.z
            };

            // Convierte el objeto en JSON
            string json = JsonUtility.ToJson(position);

            // Envía el JSON al servidor
            StartCoroutine(SendPositionToServer(json));
        }
    }

    IEnumerator SendPositionToServer(string json)
    {
        UnityWebRequest request = new UnityWebRequest(serverURL, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error sending camera position: " + request.error);
        }
    }
}
