using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; // planeta que a lua vai orbitar
    public float speed;      // velocidade da órbita
    private Vector3 orbitAxis; // eixo da órbita

    void Start()
    {
        if (target == null)
        {
            Debug.LogError("Target not assigned!");
            return;
        }
        orbitAxis = target.rotation * Vector3.up;
    }

    void Update()
    {
        if (target == null) return;
        transform.RotateAround(target.position, orbitAxis, speed * Time.deltaTime * TimeController.timeScale);
    }
}
