using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader1 : MonoBehaviour
{
    public string csvFilePath = "Assets/PuestosDeTrabajoColivriSotano120232.csv";
    public List<ComputerData1> computerDataList1 = new List<ComputerData1>(); // Store the structured data

    void Start()
    {
        ReadCSVFile(csvFilePath);


        foreach (var computerData1 in computerDataList1)
        {
            Debug.Log("Proyecto/Cargo: " + computerData1.ProyectoCargo);
            Debug.Log("Asignacion: " + computerData1.Asignacion);
            Debug.Log("Tarjeta Grafica: " + computerData1.TarjetaGrafica);
            Debug.Log("Memoria: " + computerData1.Memoria);
            Debug.Log("Almacenamiento: " + computerData1.Almacenamiento);
            Debug.Log("Procesador: " + computerData1.Procesador);
            Debug.Log("Monitor: " + computerData1.Monitor);
            Debug.Log("Teclado: " + computerData1.Teclado);
            Debug.Log("Mouse: " + computerData1.Mouse);
            Debug.Log("SO: " + computerData1.SO);
            Debug.Log("SW Relevante: " + computerData1.SWRelevanteInstalado);
            Debug.Log("Mantenimiento: " + computerData1.Mantenimiento);
        }


    }

    void ReadCSVFile(string filePath)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Skip the header row (column names)
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] row = line.Split(',');

                    // Ensure that the row has the expected number of columns
                    if (row.Length >= 12)
                    {
                        // Create a ComputerData object and populate it with the CSV data
                        ComputerData1 computerData1 = new ComputerData1
                        {
                            ProyectoCargo = row[0],
                            Asignacion = row[1],
                            TarjetaGrafica = row[2],
                            Memoria = row[3],
                            Almacenamiento = row[4],
                            Procesador = row[5],
                            Monitor = row[6],
                            Teclado = row[7],
                            Mouse = row[8],
                            SO = row[9],
                            SWRelevanteInstalado = row[10],
                            Mantenimiento = row[11]
                        };

                        // Add the ComputerData object to the list
                        computerDataList1.Add(computerData1);
                    }
                    else
                    {
                        Debug.LogWarning("Skipping row due to insufficient columns: " + line);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Debug.LogError("Error reading CSV file: " + e.Message);
        }
    }

}

[System.Serializable]
public class ComputerData1
{
    public string ProyectoCargo;
    public string Asignacion;
    public string TarjetaGrafica;
    public string Memoria;
    public string Almacenamiento;
    public string Procesador;
    public string Monitor;
    public string Teclado;
    public string Mouse;
    public string SO;
    public string SWRelevanteInstalado;
    public string Mantenimiento;
}
