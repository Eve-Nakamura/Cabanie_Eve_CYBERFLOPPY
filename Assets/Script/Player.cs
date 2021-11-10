using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float maxSpeedY_Up; // vitesse max du bird vers le haut
    public float maxSpeedY_Down; //vitesse max du bird vers le bas
    public float thrust_force; //puissance des ailes du bird
    public Vector3 initialPosition; //le bird est là au départ
    public Rigidbody2D _rigid; //il a un rigid body pour la gravité


    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _rigid.bodyType = RigidbodyType2D.Static;
        initialPosition = transform.position;

    }
    


    void Update()
    {
        
        // apputer sur la barre espace pour mettre un coup d'aile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.up * thrust_force, ForceMode2D.Force);
        }

        if (_rigid.velocity.y > maxSpeedY_Up)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Up);
        }

        if (_rigid.velocity.y < maxSpeedY_Down)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Down);
        }
    }

    //on le remet là où il était au début
    public void relaunchObject()
    {
        transform.position = initialPosition;
    }

}
