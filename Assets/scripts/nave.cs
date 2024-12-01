using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D _componentRigidbody2D;
    private float horizontal;
    private float vertical;
    public AudioSource sfxManager;
    public GameObject prefabBullet;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();

    }

    void Start()
    {

    }
    void Shoot()
    {
        Instantiate(prefabBullet, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) == true )
        {
            Shoot();
            sfxManager.Play();
        }
    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}