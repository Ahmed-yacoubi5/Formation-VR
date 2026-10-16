
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float verticalSpeed = 2f; // Units per second
    [SerializeField] private float verticalDistance = 2f;
    private Vector3 startPosition;
    private Vector3 startRotation;
    void Start()
    {
         startPosition = transform.position;
         startRotation = transform.rotation.eulerAngles;
    }
    private void resetPosition()
    {
        
         startPosition = transform.position;
         startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        
         float verticalOffset = Mathf.Sin(Time.time * verticalSpeed) * verticalDistance;
         transform.position = startPosition + new Vector3(0f, verticalOffset, 0f);
    }
}
