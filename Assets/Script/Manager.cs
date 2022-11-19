using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{


   public GameObject pos1;
   public GameObject pos2;
   public GameObject pos3;
  public  GameObject pos4;
    float pausetimer = 1f;
    public GameObject pausemenu;
    bool paused = false;
    public GameObject box;
    public float timer = 4f;
    float timer2 = 4f;
    public TextMeshProUGUI text;
    public int Score;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer2 > 1)
        {
            timer2 -= Time.deltaTime / 25f;
        }
        pausetimer -= Time.deltaTime;
        if (!paused && Input.GetKeyDown(KeyCode.Escape) && pausetimer < 0)
        {
            pausetimer = 0.5f;
            pausemenu.SetActive(true);
            paused = true;
        }
        if (paused && Input.GetKeyDown(KeyCode.Escape) && pausetimer < 0)
        {
            pausetimer = 0.5f;
            pausemenu.SetActive(false);
            paused = false;
        }
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            float x = Random.Range(pos1.transform.position.x, pos2.transform.position.x);
            float y = Random.Range(pos3.transform.position.y, pos4.transform.position.y);
            Instantiate(box, new Vector2(x, y), Quaternion.identity);
            timer = timer2;
        }
       
        if (Score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", Score);
        }
        PlayerPrefs.SetInt("Lastscore", Score);
    }
    public void Explosion(float x, float y)
    {
        Instantiate(explosion, new Vector2(x, y), Quaternion.identity);
    }
    public void AddScore(int amount)
    {
        Score += amount;
    }
    private void FixedUpdate()
    {
        text.text = Score.ToString();
    }
}

