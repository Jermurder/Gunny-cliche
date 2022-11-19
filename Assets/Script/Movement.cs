using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{


    public Image fill;
    public Slider slider;
    public bool menu = false;
    public Animator playeranim;
    GameObject cinemachine;
    CinemachineShake cinemachineshake;
    GameObject lastbul;
    public GameObject guntip;
    public GameObject bullet;
    Vector2 current;
    public Animator eye;
    public ParticleSystem particle;
    float timer = 1f;
   public float boosttimer = 10f;
   public float boostimer2;
   public bool boosted;
    public Transform gun;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        
        if (menu == false)
        {
            cinemachine = GameObject.FindGameObjectWithTag("CM");

            cinemachineshake = cinemachine.GetComponent<CinemachineShake>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!menu)
        {

            boostimer2 -= Time.deltaTime;
            slider.value = boostimer2;
            fill.color = new Color(1, slider.value / 10, slider.value / 10, 1);
        }
        if (boosted)
        {
            
            boosttimer -= Time.deltaTime;
        }
        if (boosttimer <= 0)
        {
            boosted = false;
            boosttimer = 10f;
        }
      
        
        current = rb.velocity;
        timer -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timer < 0)
        {
            playeranim.Play("Scale");
            if (menu == false)
            {
                cinemachineshake.ShakeCamera(5, 0.5f);
            }
            particle.Play();
            rb.velocity = Vector3.zero;
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 direction = (Vector3)(Input.mousePosition - screenPoint);
            direction.Normalize();
            if (menu == false)
            {
                rb.AddForce(-direction * 20, ForceMode2D.Impulse);
            }
            if (boostimer2 > 0)
            {
                timer = 0.5f;
            }
            else
            {
                timer = 1f;
            }
            lastbul = Instantiate(bullet, guntip.transform.position, Quaternion.identity);
            lastbul.transform.eulerAngles = gun.eulerAngles; 

       

    }
        if (timer < 0)
        {
            rb.velocity = Vector2.zero;
            eye.Play("eye");
        }
        if (timer > 0)
        {
            eye.Play("blink");
        }
        
    }
    private void FixedUpdate()
    {
        rb.velocity = rb.velocity * 0.9f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boost")
        {
            collision.gameObject.GetComponent<Boxcreate>().shrink();
            boosted = true;
            boostimer2 = 10f;
        }
    }

}
