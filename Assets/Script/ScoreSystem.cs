using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int myScore = 0; //on d�marre � 0

    public void addScore()
    {


        myScore++; //on rajoute un point � chaque checkpoint donc on l'affiche sur l'interface
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

    public void resetScore()
    {
        myScore = 0; //on reset tout quand le joueur perd
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }
}
