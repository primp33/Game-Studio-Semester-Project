using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float attackRange = 1f;
    public float destroyDelay = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has entered attack range, create explosion effect and destroy enemy
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, destroyDelay);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a circle around the enemy to indicate its attack range
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }





}
