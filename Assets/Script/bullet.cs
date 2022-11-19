
using UnityEngine;

public class bullet : MonoBehaviour
{
   
    AudioSource sound;
    public float speed = 20f;
    
    Rigidbody2D rb;

   
    void Start()
    {
        sound = transform.GetComponent<AudioSource>();
        sound.Play();
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * speed;
        transform.parent = null;

        Destroy(gameObject, 4f);
    }
   
}
