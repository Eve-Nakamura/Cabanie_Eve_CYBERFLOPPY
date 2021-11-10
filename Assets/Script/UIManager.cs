using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//permet de g�rer les �crans d'UI lors du game over
public class UIManager : MonoBehaviour
{

    public GameObject start_panel;
    public GameObject gameOverPanel;

    void Start()
    {
        
        gameOverPanel.gameObject.SetActive(false);
        start_panel.gameObject.SetActive(true);
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
    }
}
