using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGreyBoxes : MonoBehaviour
{
    public GameObject CollidersPrefab;

    void Start()
    {
        CreateBoxesFromDesks();
    }

    void CreateBoxesFromDesks()
    {
        GameObject[] Desks1_7 = GameObject.FindGameObjectsWithTag("Desks1_7");
        GameObject[] Desks8_13 = GameObject.FindGameObjectsWithTag("Desks8_13");
        GameObject[] Desks14_16 = GameObject.FindGameObjectsWithTag("Desks14_16");
        GameObject[] Desks17_20 = GameObject.FindGameObjectsWithTag("Desks17_20");
        GameObject[] Desks22_24 = GameObject.FindGameObjectsWithTag("Desks22_24");
        GameObject[] Desks21_25 = GameObject.FindGameObjectsWithTag("Desks21_25");
        //GameObject[] Desk31 = GameObject.FindGameObjectsWithTag("Desk31");

        foreach (GameObject desks1_7 in Desks1_7)
        {
            Vector3 deskPosition1_7 = desks1_7.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders1_7 = Instantiate(CollidersPrefab, deskPosition1_7, Quaternion.identity);

            //colliders1_7.transform.position = new Vector3(0, 0, 0); 
            //colliders1_7.transform.rotation = Quaternion.Euler(0, -90, 0);


        }

        foreach (GameObject desks8_13 in Desks8_13)
        {
            Vector3 deskPosition8_13 = desks8_13.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders8_13 = Instantiate(CollidersPrefab, deskPosition8_13, Quaternion.identity);

            colliders8_13.transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        foreach (GameObject desks14_16 in Desks14_16)
        {
            Vector3 deskPosition14_16 = desks14_16.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders14_16 = Instantiate(CollidersPrefab, deskPosition14_16, Quaternion.identity);

            // Ajusta el tamaño, rotación, o cualquier otra configuración de la "grey box" si es necesario
            // colliders14_16.transform.localScale = ...;
            colliders14_16.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        foreach (GameObject desks17_20 in Desks17_20)
        {
            Vector3 deskPosition17_20 = desks17_20.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders17_20 = Instantiate(CollidersPrefab, deskPosition17_20, Quaternion.identity);

            // Ajusta el tamaño, rotación, o cualquier otra configuración de la "grey box" si es necesario
            // deskPosition17_20.transform.localScale = ...;
            // deskPosition17_20.transform.rotation = ...;
        }

        foreach (GameObject desks22_24 in Desks22_24)
        {
            Vector3 deskPosition22_24 = desks22_24.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders22_24 = Instantiate(CollidersPrefab, deskPosition22_24, Quaternion.identity);

            colliders22_24.transform.rotation = Quaternion.Euler(0, -180, 0);
        }

        foreach (GameObject desks21_25 in Desks21_25)
        {
            Vector3 deskPosition21_25 = desks21_25.transform.position;

            // Crea la "grey box" en la posición del escritorio
            GameObject colliders21_25 = Instantiate(CollidersPrefab, deskPosition21_25, Quaternion.identity);

            colliders21_25.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        //foreach (GameObject desk31 in Desk31)
        //{
        //    Vector3 deskPosition31 = desk31.transform.position;
        //    GameObject collider31 = Instantiate(CollidersPrefab, deskPosition31, Quaternion.identity);
        //}
    }
}
