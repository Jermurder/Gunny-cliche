using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousepos.x, mousepos.y, 0);
    }
}
