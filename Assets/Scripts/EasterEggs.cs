using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggs : MonoBehaviour
{

    public GameObject StarWars;
    public GameObject Ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StarWarsActivate()
    {
        // Activa el objeto
        StarWars.SetActive(true);

        // Llama a la función para desactivar después de 6 segundos
        Invoke("DesactivarStarWars", 6f);
    }

    void DesactivarStarWars()
    {
        // Desactiva el objeto después de 6 segundos
        StarWars.SetActive(false);
    }

    public void ShipActivate()
    {
        // Activa el objeto
        Ship.SetActive(true);

        // Llama a la función para desactivar después de 6 segundos
        Invoke("DesactivarShip", 6f);
    }

    void DesactivarShip()
    {
        // Desactiva el objeto después de 6 segundos
        Ship.SetActive(false);
    }
}
