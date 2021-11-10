using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour //à chaque fois que le player passe dessus, le score augmente de 1
{
    public float Speed;
    public Vector3 initialPosition; //leur pose de départ
    // on crée le système de spon des checkpoint
    void Start()
    {
        transform.position -= Vector3.right * Speed; //on les fait bouger dès le départ en même temps que les obstacles

    }

    void Update()
    {
        transform.position -= Vector3.right * Speed; //on répète l'ordre à chaque frame
    }
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
       
        if (p_collision.GetComponent<Player>() != null)
        {
            FindObjectOfType<ScoreSystem>().addScore(); //on leur met une collision pour update le score
        }


    }

    public void relaunchObject()
    {
        transform.position = initialPosition; //on crée la fct pour que les checkpoints reviennent à l'infini
    }
}
