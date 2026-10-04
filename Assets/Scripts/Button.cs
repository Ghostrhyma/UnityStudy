using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject platform;
    private Vector3 originalPosition;
    private bool isPressed = false;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPressed)
        {
            isPressed = true;
            transform.position = originalPosition + new Vector3(0, -0.1f, 0);
            platform.SetActive(!platform.activeSelf);
        }
    }
}



