using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        FindObjectOfType<Health>().TakeDamage(20);
        Destroy(gameObject);
    }
}
