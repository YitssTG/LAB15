using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public GameObject explosion;
    public float velocity;
    public GameManagerControl gameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            gameManager.UpdateScore(100);
            Instantiate(explosion,transform.position,transform.rotation);
        }
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.tag == "barrera")
        {
            Destroy(this.gameObject);
        }
    }
    
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _componentRigidbody2D.velocity = new Vector2(0 , velocity);
    }
    public void SetGameManager(GameManagerControl gm)
    {
        gameManager = gm;
    }
}
