using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class CameraData
{
    public float x;
    public float y;
    public float z;
    public float rotx;
    public float roty;
    public float rotz;
}

public class CameraPositionSender : MonoBehaviour
{
    private string serverURL = "http://172.24.100.110:8080/data/holop";
    public float updateInterval = 2f; // Intervalo de actualizaci�n en segundos

    private bool isApplicationPaused = false;

    private void Start()
    {
        // Inicia la actualizaci�n peri�dica
        InvokeRepeating("SendCameraData", 0f, updateInterval);
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        isApplicationPaused = pauseStatus;

        if (isApplicationPaused)
        {
            // La aplicaci�n est� en pausa o en segundo plano
            // Env�a un JSON con posici�n y rotaci�n nula al servidor
            CameraData nullData = new CameraData
            {
                x = 1000f,
                y = 1000f,
                z = 1000f,
                rotx = 1000f,
                roty = 1000f,
                rotz = 1000f
            };
            string nullDataJSON = JsonUtility.ToJson(nullData);

            StartCoroutine(SendDataToServer(nullDataJSON));
        }
    }

    private void OnApplicationQuit()
    {
        // La aplicaci�n se est� cerrando
        // Env�a un JSON con posici�n y rotaci�n nula al servidor antes de cerrar la aplicaci�n
        CameraData nullData = new CameraData
        {
            x = 1000f,
            y = 1000f,
            z = 1000f,
            rotx = 1000f,
            roty = 1000f,
            rotz = 1000f
        };
        string nullDataJSON = JsonUtility.ToJson(nullData);

        StartCoroutine(SendDataToServer(nullDataJSON));
    }

    void SendCameraData()
    {
        if (!isApplicationPaused)
        {
            // La aplicaci�n no est� en pausa o en segundo plano
            // Obt�n la posici�n y rotaci�n de la c�mara principal
            Transform cameraTransform = Camera.main.transform;
            Vector3 cameraPosition = cameraTransform.position;
            Vector3 cameraRotation = cameraTransform.eulerAngles;

            // Crea un objeto CameraData y asigna la posici�n y rotaci�n
            CameraData data = new CameraData
            {
                x = cameraPosition.x,
                y = cameraPosition.y,
                z = cameraPosition.z,
                rotx = cameraRotation.x - 90f,
                roty = cameraRotation.y,
                rotz = cameraRotation.z
            };

            // Convierte el objeto en JSON
            string json = JsonUtility.ToJson(data);

            // Env�a el JSON al servidor
            StartCoroutine(SendDataToServer(json));
        }
    }

    IEnumerator SendDataToServer(string json)
    {
        UnityWebRequest request = new UnityWebRequest(serverURL, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error sending camera data: " + request.error);
        }
    }
}
