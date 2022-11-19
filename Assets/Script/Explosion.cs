using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public bool menu = false;
    GameObject cinemachine;
    CinemachineShake cinemachineshake;
    AudioSource sound;
    ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        if (menu == false)
        {
            Explode();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Explode()
    {
        cinemachine = GameObject.FindGameObjectWithTag("CM");
        cinemachineshake = cinemachine.GetComponent<CinemachineShake>();
        cinemachineshake.ShakeCamera(10, 1);
        sound = transform.GetComponent<AudioSource>();
        sound.Play();
        explosion = transform.GetComponent<ParticleSystem>();
        explosion.Play();
        if (menu == false)
        {
            Destroy(gameObject, 1);
        }
    }
}
