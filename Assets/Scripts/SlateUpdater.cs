using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlateUpdater : MonoBehaviour
{
    public TextMeshPro proyectoText; // Reference to the TextMeshPro component for the Proyecto column
    public TextMeshPro asignacionText; // Reference to the TextMeshPro component for the Asigancion column
    public TextMeshPro procesadorText; // Reference to the TextMeshPro component for the Procesador column
    public TextMeshPro memoriaText; // Reference to the TextMeshPro component for the Memoria column
    public TextMeshPro almacenamientoText; // Reference to the TextMeshPro component for the Almacenamiento colum
    public TextMeshPro tarjetaGraficaText; // Reference to the TextMeshPro component for the Tarjeta Grafica column
    public CSVReader csvReader; // Reference to the CSVReader script
    public int computerIndex; // Index of the computer this slate corresponds to

    private void Start()
    {
        UpdateTitleText();
    }

    private void UpdateTitleText()
    {
        // Access the CSV data from the CSVReader script
        var computerDataList = csvReader.computerDataList; // Get the list of computer data

        // Check if there's data in the list
        //Debug.Log("DataList: " + computerDataList);
        if (computerDataList != null && computerDataList.Count >= computerIndex)
        {
            var computerData = computerDataList[computerIndex];
            var proyectoCargo = computerData.ProyectoCargo;
            var asignacion = computerData.Asignacion;
            var procesador = "Procesador: " + computerData.Procesador;
            var memoria = "Memoria total: " + computerData.Memoria;
            var almacenamiento = "Almacenamiento total: " + computerData.Almacenamiento;
            var tarjetaGrafica = computerData.TarjetaGrafica;


            Debug.Log("Proyecto/Cargo: " + proyectoCargo);

            proyectoText.text = proyectoCargo; // Update with the appropriate property
            asignacionText.text = asignacion; // Update with the appropriate property
            procesadorText.text = procesador; // Update with the appropriate property
            memoriaText.text = memoria; // Update with the appropriate property
            almacenamientoText.text = almacenamiento; // Update with the appropriate property
            tarjetaGraficaText.text = tarjetaGrafica; // Update with the appropriate property
        }
        else
        {
            proyectoText.text = "No Data Available";
            asignacionText.text = "No Data Available";
            memoriaText.text = "No Data Available";
            almacenamientoText.text = "No Data Available";
            procesadorText.text = "No Data Available";
            tarjetaGraficaText.text = "No Data Available";

        }
    }
}
