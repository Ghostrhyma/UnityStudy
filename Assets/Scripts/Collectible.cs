using UnityEngine;

public class Collectible: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Предмет собран");
            Destroy(gameObject);
        }
    }
}
