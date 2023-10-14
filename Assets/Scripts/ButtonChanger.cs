using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChanger : MonoBehaviour
{
    public GameObject currentButton;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject Button7;
    public GameObject Button8;
    public GameObject Button9;
    public GameObject Button10;
    public GameObject Button11;
    public GameObject Button12;
    public GameObject Button13;
    public GameObject ButtonProyecto;
    public GameObject ButtonAsignacion;
    public GameObject ButtonProcesador;
    public GameObject ButtonMemoria;
    public GameObject ButtonAlmacenamiento;
    public GameObject ButtonGrafica;
    public GameObject ButtonBack;
    public GameObject ButtonMonitor;
    public GameObject ButtonTeclado;
    public GameObject ButtonMouse;
    public GameObject ButtonSO;
    public GameObject ButtonSW;
    public GameObject ButtonMantenimiento;
    public void change()
    {
        if (currentButton != null)
        {
            currentButton.SetActive(false);
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            Button4.SetActive(false);
            Button5.SetActive(false);
            Button6.SetActive(false);
            Button7.SetActive(false);
            Button8.SetActive(false);
            Button9.SetActive(false);
            Button10.SetActive(false);
            Button11.SetActive(false);
            Button12.SetActive(false);
            Button13.SetActive(false);
            ButtonProyecto.SetActive(true);
            ButtonAsignacion.SetActive(true);
            ButtonProcesador.SetActive(true);
            ButtonMemoria.SetActive(true);
            ButtonAlmacenamiento.SetActive(true);
            ButtonGrafica.SetActive(true);
            ButtonBack.SetActive(true);
            ButtonMonitor.SetActive(true);
            ButtonTeclado.SetActive(true);
            ButtonMouse.SetActive(true);
            ButtonSO.SetActive(true);
            ButtonSW.SetActive(true);
            ButtonMantenimiento.SetActive(true);
        }
        else
        {
            //Debug.Log("Button: " + "No lo reconoce");
        }
    }

    public void back()
    {
        if (ButtonBack != null)
        {
            currentButton.SetActive(true);
            Button1.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(true);
            Button4.SetActive(true);
            Button5.SetActive(true);
            Button6.SetActive(true);
            Button7.SetActive(true);
            Button8.SetActive(true);
            Button9.SetActive(true);
            Button10.SetActive(true);
            Button11.SetActive(true);
            Button12.SetActive(true);
            Button13.SetActive(true);
            ButtonProyecto.SetActive(false);
            ButtonAsignacion.SetActive(false);
            ButtonProcesador.SetActive(false);
            ButtonMemoria.SetActive(false);
            ButtonAlmacenamiento.SetActive(false);
            ButtonGrafica.SetActive(false);
            ButtonBack.SetActive(false);
            ButtonMonitor.SetActive(false);
            ButtonTeclado.SetActive(false);
            ButtonMouse.SetActive(false);
            ButtonSO.SetActive(false);
            ButtonSW.SetActive(false);
            ButtonMantenimiento.SetActive(false);
        }
        else
        {
            //Debug.Log("ButtonBack: " + "No lo reconoce");
        }
    }


}
