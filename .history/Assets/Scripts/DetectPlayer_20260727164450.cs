using System;
using UnityEngine;
using UnityEngine.video;
public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private ObjectRotation rotation ;
    [SerializeField] private SoundControl soundControl ;
    [SerializeField] private GameObject flagObject ;

    private void Start()
    {
        flagObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            flagObject.SetActive(true);
            
            Debug.Log("Player is detected");
            if (rotation != null)
            {
                rotation.PauseAndReset();
                soundControl.PlayVideo();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            flagObject.SetActive(false);
            if (rotation != null)
            {
                rotation.Resume();
                soundControl.StopVideo();
            }
        }
    }
}