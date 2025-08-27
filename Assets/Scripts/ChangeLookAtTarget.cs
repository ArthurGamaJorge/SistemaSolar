using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeLookAtTarget : MonoBehaviour
{
    public GameObject target; // target da câmera

    void Start()
    {
        if (target == null)
            target = this.gameObject;
    }

    void OnMouseDown()
    {
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            return;

        LookAtTarget lookScript = Camera.main.GetComponent<LookAtTarget>();
        if (lookScript != null)
            lookScript.ChangeTarget(target);
    }
}
