using UnityEngine;

public class TimeController : MonoBehaviour
{
    // Velocidade global do tempo
    public static float timeScale = 1.0f;

    void Update()
    {
        // Opcional: controle por teclado
        if (Input.GetKeyDown(KeyCode.Equals)) // tecla "+" aumenta velocidade
        {
            timeScale *= 2f;
        }
        if (Input.GetKeyDown(KeyCode.Minus)) // tecla "-" diminui velocidade
        {
            timeScale *= 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0)) // tecla "0" reseta
        {
            timeScale = 1f;
        }
    }
}
