using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            dead = true;
            Lose();
        }
    }
    void Lose()
    {
        LoadScript loader = GameObject.FindGameObjectWithTag("Loader").GetComponent<LoadScript>();
        loader.Load(0);
        
    }
}
