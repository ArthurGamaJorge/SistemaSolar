using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    static public GameObject target; // planeta que a câmera deve olhar
    private AudioSource currentAudio;

    void Start()
    {
        if (target == null)
        {
            target = GameObject.Find("Luz Solar"); 
            if (!target)
                target = this.gameObject;
        }

        PlayAudio(target);
    }

    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }

    public void ChangeTarget(GameObject newTarget)
    {
        if (newTarget == null) return;
        target = newTarget;
        PlayAudio(target);
        
        if (Camera.main)
            Camera.main.fieldOfView = 60 * target.transform.localScale.x;
    }

    private void PlayAudio(GameObject obj)
    {
        if (!obj) return;

        AudioSource audio = obj.GetComponent<AudioSource>();
        if (!audio) return;

        if (currentAudio && currentAudio.isPlaying)
            currentAudio.Stop();

        audio.Play();
        currentAudio = audio;
    }
}
