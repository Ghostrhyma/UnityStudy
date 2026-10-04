using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10;
    public float attackRange = 2f;
    public float attackRate = 1f;
    private float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            Collider[] hitPlayers = Physics.OverlapSphere(transform.position, attackRange);
            foreach (Collider player in hitPlayers)
            {
                if (player.CompareTag("Player"))
                {
                    player.GetComponent<PlayerHealth>().TakeDamage(damage);
                    nextAttackTime = Time.time + 1f / attackRate;
                }
            }
        }
    }
}
