using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//permet de gérer les écrans d'UI lors du game over
public class UIManager : MonoBehaviour
{

    public GameObject start_panel;
    public GameObject gameOverPanel;

    void Start()
    {
        
        gameOverPanel.gameObject.SetActive(false); //l'écran de game over est désactivé
        start_panel.gameObject.SetActive(true); //l'écran de start de jeu est affiché
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true); //on affiche l'écran de game over
    }
}
