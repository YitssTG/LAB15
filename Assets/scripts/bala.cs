using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocity;
    public AudioSource explosion;
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(0, velocity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.tag == "barrera")
        {
            Destroy(this.gameObject);
        }
    }
}
