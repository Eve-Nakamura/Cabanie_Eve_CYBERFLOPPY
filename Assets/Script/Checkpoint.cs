using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour //� chaque fois que le player passe dessus, le score augmente de 1
{
    public float Speed;
    public Vector3 initialPosition; //leur pose de d�part
    // on cr�e le syst�me de spon des checkpoint
    void Start()
    {
        transform.position -= Vector3.right * Speed; //on les fait bouger d�s le d�part en m�me temps que les obstacles

    }

    void Update()
    {
        transform.position -= Vector3.right * Speed; //on r�p�te l'ordre � chaque frame
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
        transform.position = initialPosition; //on cr�e la fct pour que les checkpoints reviennent � l'infini
    }
}
