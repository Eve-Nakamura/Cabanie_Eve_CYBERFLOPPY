using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// fonction principales du jeu
public class GameManager : MonoBehaviour
{
    public void startGame() //démarrer le jeu
    {
        UIManager _uiManager = FindObjectOfType<UIManager>();
        _uiManager.start_panel.SetActive(false); //l'écran d'accueil s'enlève
        Player _player = FindObjectOfType<Player>(); //on active le player
        _player._rigid.bodyType = RigidbodyType2D.Dynamic;
        Pipe[] _pipes = FindObjectsOfType<Pipe>(); //et les obstacles
        foreach (Pipe _pipe in _pipes)
        {
            _pipe.enabled = true;
        }

    }
    public void relaunchGame() //hop là on relance le jeu si le bird se prend un pipe
    {   //on récupère ts les objets
        Player _player = FindObjectOfType<Player>();
        Checkpoint[] _checkpoints = FindObjectsOfType<Checkpoint>();
        Pipe[] _pipes = FindObjectsOfType<Pipe>();

        // on les relance
        foreach (Checkpoint item in _checkpoints)
        {
            item.relaunchObject();
        }
        foreach (Pipe _pipe in _pipes)
        {
            _pipe.relaunchObject();
        }
        _player.relaunchObject();

        UIManager _uiManager = FindObjectOfType<UIManager>();

        _uiManager.gameOverPanel.SetActive(false); //et on désactive le panneau de game over

        ScoreSystem _score = FindObjectOfType<ScoreSystem>();

        _score.resetScore(); //le score est remis à zéro

    }
}
