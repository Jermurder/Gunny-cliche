using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Shatter : MonoBehaviour
{
   public bool quit = false;
    float coloralpha = 1f;
    bool lerping;
    public TextMeshProUGUI text;
    public Rigidbody2D menu1;
    public Rigidbody2D menu2;
    public Rigidbody2D menu3;
    // Start is called before the first frame update
    void Start()
    {
        menu1.isKinematic = true;
        menu2.isKinematic = true;
        menu3.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (lerping)
        {
            coloralpha -= Time.deltaTime;
            
            Color color = new Color(1, 1, 1, coloralpha);
            text.color = color;
        }
    }
    public void Shatterfunc()
    {
        gameObject.GetComponent<Explosion>().Explode();
        lerping = true;
        menu1.isKinematic = false;
        menu2.isKinematic = false;
        menu3.isKinematic = false;
        menu1.velocity = new Vector2(-1, 1);
        menu2.velocity = new Vector2(0, 2);
        menu2.velocity = new Vector2(1, 1);
        LoadScript loader = GameObject.FindGameObjectWithTag("Loader").GetComponent<LoadScript>();
        loader.Load(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
            if (collision.gameObject.tag == "Bullet")
            {

            if (!quit)
            {
                Shatterfunc();
            }
            
            if (quit)
            {
                gameObject.GetComponent<Explosion>().Explode();
                lerping = true;
                menu1.isKinematic = false;
                menu2.isKinematic = false;
                menu3.isKinematic = false;
                menu1.velocity = new Vector2(-1, 1);
                menu2.velocity = new Vector2(0, 2);
                menu2.velocity = new Vector2(1, 1);
                Quit();
            }
        }

        
    }
}
