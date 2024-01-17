using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private int _score;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void boutton_touch()
    {
        GetComponent<Animation>().Play("button_play");
  
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RiseScore(int amount)
    {
        _score += amount;
        scoreText.text = _score.ToString("0000");
    }
}
