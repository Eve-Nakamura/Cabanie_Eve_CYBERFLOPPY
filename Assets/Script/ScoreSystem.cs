using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int myScore = 0;

    public void addScore()
    {


        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

    public void resetScore()
    {
        myScore = 0;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }
}
