
using UnityEngine;

public class detection : MonoBehaviour
{
     [SerializeField] private string playerTag = "Player"; // Make sure your player GameObject has this tag
    [SerializeField] private ObjectRotator rotatingObject; // Drag the rotating object here in Inspector
 
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is the player
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Player entered the trigger zone! Stopping rotation...");
            
            // Disable the ObjectRotator script to stop rotation and movement
            if (rotatingObject != null)
                rotatingObject.enabled = false;
        }
    }
 
    private void OnTriggerExit(Collider other)
    {
        // Optional: Resume when player leaves
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Player left the trigger zone! Resuming rotation...");
            
            // Re-enable the ObjectRotator script
            if (rotatingObject != null)
                rotatingObject.enabled = true;
        }
    }

}
