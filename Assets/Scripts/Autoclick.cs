using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclick : MonoBehaviour
{

    public ScoreManager scoreManager;
    public int clickPower;
    public float timeBetClick = 1;

    void Start()
    {
        StartCoroutine(AutoClicker());
    }
    
    private IEnumerator AutoClicker()
    {
        while (true)
        {
            scoreManager.RiseScore(clickPower);
            yield return new WaitForSeconds(timeBetClick);
        }
    }


}
