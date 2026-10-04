using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public float chaseRange = 10f;
    private Rigidbody rb;


    private void Start()
    {
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < chaseRange) 
        {
            Vector3 direction = (player.position - transform.position).normalized;
            direction.y = 0;
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

            if (direction != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(direction);
                rb.rotation = Quaternion.Slerp(rb.rotation, lookRotation, 10f * Time.fixedDeltaTime);
            }
        }
    }

}
