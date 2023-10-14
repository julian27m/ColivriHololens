using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlateUpdater1 : MonoBehaviour
{
    //public TextMeshPro proyectoText; // Reference to the TextMeshPro component for the Proyecto column
    //public TextMeshPro proyectoText2; // Reference to the TextMeshPro component for the Proyecto column
    //public TextMeshPro asignacionText; // Reference to the TextMeshPro component for the Asigancion column
    //public TextMeshPro asignacionText2; // Reference to the TextMeshPro component for the Asigancion column
    public TextMeshPro procesadorText; // Reference to the TextMeshPro component for the Procesador column
    //public TextMeshPro procesadorText2; // Reference to the TextMeshPro component for the Procesador column
    public TextMeshPro memoriaText; // Reference to the TextMeshPro component for the Memoria column
    //public TextMeshPro memoriaText2; // Reference to the TextMeshPro component for the Memoria column
    public TextMeshPro almacenamientoText; // Reference to the TextMeshPro component for the Almacenamiento column
    //public TextMeshPro almacenamientoText2; // Reference to the TextMeshPro component for the Almacenamiento column
    //public TextMeshPro tarjetaGraficaText; // Reference to the TextMeshPro component for the Tarjeta Grafica column
    //public TextMeshPro tarjetaGraficaText2; // Reference to the TextMeshPro component for the Tarjeta Grafica column
    //public TextMeshPro monitorText; // Reference to the TextMeshPro component for the Monitor column
    //public TextMeshPro tecladoText; // Reference to the TextMeshPro component for the Teclado column
    //public TextMeshPro tecladoText2; // Reference to the TextMeshPro component for the Teclado column
    //public TextMeshPro mouseText; // Reference to the TextMeshPro component for the Mouse column
    //public TextMeshPro mouseText2; // Reference to the TextMeshPro component for the Mouse column
    //public TextMeshPro soText; // Reference to the TextMeshPro component for the SO column
    //public TextMeshPro soText2; // Reference to the TextMeshPro component for the SO column
    //public TextMeshPro swRelevanteText; // Reference to the TextMeshPro component for SW Relevante Instalado column
    //public TextMeshPro mantenimientoText; // Reference to the TextMeshPro component for the Mantenimiento column
    public CSVReader1 csvReader; // Reference to the CSVReader script
    //public TextMeshPro headerText; // Reference to the desk number
    public int computerIndex; // Index of the computer this slate corresponds to

    private void Start()
    {
        UpdateTitleText();
    }

    private void UpdateTitleText()
    {
        // Access the CSV data from the CSVReader script
        var computerDataList1 = csvReader.computerDataList1; // Get the list of computer data

        // Check if there's data in the list
        //Debug.Log("DataList: " + computerDataList);
        if (computerDataList1 != null && computerDataList1.Count >= computerIndex)
        {
            var computerData1 = computerDataList1[computerIndex];
            var proyectoCargo = computerData1.ProyectoCargo;
            var asignacion = computerData1.Asignacion;
            var procesador = "Procesador: " + computerData1.Procesador;
            var memoria = "Memoria total: " + computerData1.Memoria;
            var almacenamiento = "Almacenamiento total: " + computerData1.Almacenamiento;
            var tarjetaGrafica = computerData1.TarjetaGrafica;
            var monitor = computerData1.Monitor;
            var teclado = computerData1.Teclado;
            var mouse = computerData1.Mouse;
            var so = computerData1.SO;
            var swRelevante = computerData1.SWRelevanteInstalado;
            var mantenimiento = computerData1.Mantenimiento;
            //Debug.Log("Header: " + headerText.text);

            // Get the computer data for this slate's computer


            // Assuming this slate corresponds to the computer at computerIndex

            Debug.Log("Proyecto/Cargo: " + proyectoCargo);

            // Update the title TextMeshPro with the relevant data
            //proyectoText.text = proyectoCargo; // Update with the appropriate property
            //asignacionText.text = asignacion; // Update with the appropriate property
            procesadorText.text = procesador; // Update with the appropriate property
            memoriaText.text = memoria; // Update with the appropriate property
            almacenamientoText.text = almacenamiento; // Update with the appropriate property
            //tarjetaGraficaText.text = tarjetaGrafica; // Update with the appropriate property
            //monitorText.text = monitor; // Update with the appropriate property
            //tecladoText.text = teclado; // Update with the appropriate property
            //mouseText.text = mouse; // Update with the appropriate property
            //soText.text = so; // Update with the appropriate property
            //swRelevanteText.text = swRelevante; // Update with the appropriate property
            //mantenimientoText.text = mantenimiento; // Update with the appropriate property

            //proyectoText2.text = proyectoCargo; // Update with the appropriate property
            //asignacionText2.text = asignacion; // Update with the appropriate property
            //procesadorText2.text = procesador; // Update with the appropriate property
            //memoriaText2.text = memoria; // Update with the appropriate property
            //almacenamientoText2.text = almacenamiento; // Update with the appropriate property
            //tarjetaGraficaText2.text = tarjetaGrafica; // Update with the appropriate property
            //tecladoText2.text = teclado; // Update with the appropriate property
            //mouseText2.text = mouse; // Update with the appropriate property
            //soText2.text = so; // Update with the appropriate property


        }
        else
        {
            // Handle the case where no data is available (e.g., show an error message)
            //proyectoText.text = "No Data Available";
            //asignacionText.text = "No Data Available";
            memoriaText.text = "No Data Available";
            almacenamientoText.text = "No Data Available";
            procesadorText.text = "No Data Available";
            //tarjetaGraficaText.text = "No Data Available";
            //monitorText.text = "No Data Available";
            //tecladoText.text = "No Data Available";
            //mouseText.text = "No Data Available";
            //soText.text = "No Data Available";
            //swRelevanteText.text = "No Data Available";
            //  mantenimientoText.text = "No Data Available";
            //proyectoText2.text = "No Data Available";
            //asignacionText2.text = "No Data Available";
            //memoriaText2.text = "No Data Available";
            //almacenamientoText2.text = "No Data Available";
            //procesadorText2.text = "No Data Available";
            //tarjetaGraficaText2.text = "No Data Available";
            //tecladoText2.text = "No Data Available";
            //mouseText2.text = "No Data Available";
            //soText2.text = "No Data Available";
        }
    }
}
