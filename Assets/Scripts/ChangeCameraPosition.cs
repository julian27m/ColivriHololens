using UnityEngine;
using UnityEngine.XR;

public class ChangeCameraPosition : MonoBehaviour
{
    public GameObject mrtkXRRig;

    public Vector3 position1 = new Vector3(0.365999997f, 0.739000022f, 0.0659999996f);
    public Vector3 positionS1 = new Vector3(2.4375f, -3.98600006f, -2.46700001f);

    public void CamaraPiso1()
    {
        // Asegúrate de que el objeto MRTK XR Rig esté disponible
        if (mrtkXRRig != null)
        {
            // Cambia la posición del objeto MRTK XR Rig
            mrtkXRRig.transform.position = position1;
        }
        else
        {
            Debug.LogWarning("No se ha asignado el objeto MRTK XR Rig.");
        }
    }

    public void CamaraSotano1()
    {
        // Asegúrate de que el objeto MRTK XR Rig esté disponible
        if (mrtkXRRig != null)
        {
            // Cambia la posición del objeto MRTK XR Rig
            mrtkXRRig.transform.position = positionS1;
        }
        else
        {
            Debug.LogWarning("No se ha asignado el objeto MRTK XR Rig.");
        }
    }
}
