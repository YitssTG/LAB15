using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float contador;
    public float limite;
    public float max;
    public float min;
    public GameManagerControl gameManager;
    void Awake()
    {
       
    }

    void Update()
    {
        if( contador > limite)
        {  
            float position = Random.Range(min, max);
            GameObject enemy = Instantiate(prefabEnemy, new Vector2(position,transform.position.y), transform.rotation);
            enemy.GetComponent<enemy>().SetGameManager(gameManager);
            contador = 0;
            
        }
        contador = contador + Time.deltaTime;
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
}
