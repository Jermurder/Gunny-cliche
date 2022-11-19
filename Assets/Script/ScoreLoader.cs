using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreLoader : MonoBehaviour
{
    public TextMeshProUGUI high;
    public TextMeshProUGUI last;
    // Start is called before the first frame update
    void Start()
    {
        high.text = "High score: " + PlayerPrefs.GetInt("Highscore").ToString();
        last.text = "Last score: "+ PlayerPrefs.GetInt("Lastscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
