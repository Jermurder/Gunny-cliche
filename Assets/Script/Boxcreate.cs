using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxcreate : MonoBehaviour
{
    Animator anim;
    SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator>();
        image = transform.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = Color.Lerp(image.color, new Color(1, 1, 1, 0), 0.0005f);
        if (image.color == new Color(1, 1, 1, 0))
        {
            shrink();
        }
    }

    public void Destroything()
    {
        Destroy(gameObject);
    }
    public void shrink()
    {
        anim.Play("Shrink");
    }
}
