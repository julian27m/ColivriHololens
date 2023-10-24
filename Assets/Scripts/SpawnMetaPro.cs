using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class MetaProCameraPositionGet
{
    public float x;
    public float y;
    public float z;
}

public class SpawnMetaPro : MonoBehaviour
{
    public GameObject metaPro;
    private string serverURLMetaPro = "http://18.188.1.225:8080/data/metapro";

    void Start()
    {
        StartCoroutine(UpdateMetaProPosition());
    }

    IEnumerator UpdateMetaProPosition()
    {
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get(serverURLMetaPro);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;

                MetaProCameraPositionGet position = JsonUtility.FromJson<MetaProCameraPositionGet>(json);

                float xPos = position.x;
                float yPos = position.y;
                float zPos = position.z;

                if (xPos == 1000f && yPos == 1000f && zPos == 1000f)
                {
                    // La posición es (1000, 1000, 1000), desactiva el objeto
                    metaPro.SetActive(false);
                }
                else
                {
                    // La posición no es (1000, 1000, 1000), activa el objeto y establece su posición
                    metaPro.SetActive(true);
                    metaPro.transform.position = new Vector3(xPos + 8.81945f, yPos - 6.8063f, zPos + 1.14023f);
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
