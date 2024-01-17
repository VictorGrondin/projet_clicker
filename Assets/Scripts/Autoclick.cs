using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Autoclick : MonoBehaviour
{

    public ScoreManager scoreManager;
    public int clickPower;
    public float timeBetClick = 1; 

    public void StartAutoclick()
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
