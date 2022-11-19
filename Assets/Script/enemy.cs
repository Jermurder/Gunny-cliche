using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    GameObject manager;
    Manager managerscript;

    Vector2 target;
    Transform player;
    Transform childtrans;
    Rigidbody2D rb;
    float movespeed = 3f;

    Vector3 currot;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        managerscript = manager.GetComponent<Manager>();
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        childtrans = transform.GetChild(0);
        rb = transform.GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {

        target = player.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target, movespeed * Time.deltaTime);

     
    }
    private void FixedUpdate()
    {
        currot = new Vector3(0, 0, transform.eulerAngles.z + 0.3f);
        transform.eulerAngles = currot;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            managerscript.Explosion(transform.position.x, transform.position.y);
            Destroy(gameObject);
            managerscript.AddScore(1);
        }
    }
   
}
