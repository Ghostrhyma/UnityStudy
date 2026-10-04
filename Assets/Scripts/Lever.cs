using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject platform;
    private bool isActivated = false;

    private Quaternion offRotation;
    private Quaternion onRotation;

    private void Start()
    {
        offRotation = transform.localRotation;
        onRotation = offRotation * Quaternion.Euler(0, 0, 45f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivated = !isActivated;

            if (platform != null)
            {
                platform.SetActive(isActivated);
            }
            
            transform.localRotation = isActivated ? onRotation : offRotation;
            Debug.Log("Рычаг переключен");
        }
    }
}
