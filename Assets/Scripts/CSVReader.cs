using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{
    public string csvFilePath = "PuestosDeTrabajoColivriPiso120232";
    public List<ComputerData> computerDataList = new List<ComputerData>();

    void Start()
    {
        // Utiliza Resources.Load para cargar el archivo CSV
        TextAsset csvFile = Resources.Load<TextAsset>(csvFilePath);

        if (csvFile != null)
        {
            StringReader sr = new StringReader(csvFile.text);

            ReadCSVFile(sr);

            foreach (var computerData in computerDataList)
            {
                Debug.Log("Proyecto/Cargo: " + computerData.ProyectoCargo);
                Debug.Log("Asignacion: " + computerData.Asignacion);
                Debug.Log("Tarjeta Grafica: " + computerData.TarjetaGrafica);
                Debug.Log("Memoria: " + computerData.Memoria);
                Debug.Log("Almacenamiento: " + computerData.Almacenamiento);
                Debug.Log("Procesador: " + computerData.Procesador);
            }
        }
        else
        {
            Debug.LogError("Error loading CSV file from Resources.");
        }
    }

    void ReadCSVFile(StringReader sr)
    {
        try
        {
            sr.ReadLine(); 

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null) break; 
                string[] row = line.Split(',');

                if (row.Length >= 12)
                {
                    ComputerData computerData = new ComputerData
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

                    computerDataList.Add(computerData);
                }
                else
                {
                    Debug.LogWarning("Skipping row due to insufficient columns: " + line);
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
public class ComputerData
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
