using UnityEngine;
using UnityEngine.UI;

public class RAMSliderController : MonoBehaviour
{
    public Slider ramSlider;

    void Update()
    {
        // Accede al valor actual del slider
        float ramValue = ramSlider.value;
        // Utiliza ramValue en tu l�gica para controlar algo, como filtrar objetos seg�n el valor del slider.
    }
}
