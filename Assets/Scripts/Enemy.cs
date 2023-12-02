using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab;
    private Rigidbody2D _compRigidbody;
    public float speedY;
    public float directionY;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this. gameObject);
        }

    }
}
