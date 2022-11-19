using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class LoadScript : MonoBehaviour
{
    GameObject maincam;
    AudioSource music;
    Animator anim;
    int scenel;
    Color visible = new Color(1, 1, 1, 1);
    Color invisible = new Color(1, 1, 1, 0);

    private void Start()
    {

        
        maincam = GameObject.FindGameObjectWithTag("MainCamera");
        music = maincam.GetComponent<AudioSource>();
        music.time = PlayerPrefs.GetInt("musictime");
        music = maincam.GetComponent<AudioSource>();
        anim = transform.GetComponent<Animator>();
        anim.Play("Open");
    }
    public void Load(int scene)
    {
        PlayerPrefs.SetFloat("musictime", music.time);
        anim.Play("Close");
        scenel = scene;
        
    }
    public void loadscene()
    {
        
        SceneManager.LoadScene(scenel);
    }
    public void Invisible()
    {
        transform.GetComponent<SpriteRenderer>().color = invisible;
    }
    public void Visible()
    {
        transform.GetComponent<SpriteRenderer>().color = visible;
    }
    private void Update()
    {
      
    }

}
