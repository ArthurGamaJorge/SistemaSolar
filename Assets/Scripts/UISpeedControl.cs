using UnityEngine;
using UnityEngine.UI;
using TMPro; // se for usar TextMeshPro

public class UISpeedControl : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider speedSlider; 

    void Start()
    {
        // Configura o Slider
        speedSlider.minValue = 0.1f; 
        speedSlider.maxValue = 10f;  
        speedSlider.value = 1f;    
    }

    void Update()
    {
        TimeController.timeScale = speedSlider.value;
    }
}
