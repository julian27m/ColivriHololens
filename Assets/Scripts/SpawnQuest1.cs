using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class CameraPositionGet
{
    public float x;
    public float y;
    public float z;
}

public class SpawnQuest1 : MonoBehaviour
{
    public GameObject objectToSpawn;
    private string serverURL = "http://18.188.1.225:8080/data/meta1";

    void Start()
    {
        StartCoroutine(UpdateObjectPosition());
    }

    IEnumerator UpdateObjectPosition()
    {
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get(serverURL);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;

                CameraPositionGet position = JsonUtility.FromJson<CameraPositionGet>(json);

                float xPos = position.x;
                float yPos = position.y;
                float zPos = position.z;

                if (xPos == 0f && yPos == 0f && zPos == 0f)
                {
                    // La posición es (0, 0, 0), desactiva el objeto
                    objectToSpawn.SetActive(false);
                }
                else
                {
                    // La posición no es (0, 0, 0), activa el objeto y establece su posición
                    objectToSpawn.SetActive(true);
                    objectToSpawn.transform.position = new Vector3(xPos - 9.178f, yPos + 0.2f, zPos - 6.785f);
                }
            }
            else
            {
                Debug.LogError("Error fetching camera position: " + request.error);
            }

            // Espera x segundos antes de la próxima actualización
            yield return new WaitForSeconds(3f);
        }
    }
}
