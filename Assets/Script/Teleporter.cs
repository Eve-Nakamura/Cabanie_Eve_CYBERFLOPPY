using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour //pour t�l�porter 
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Pipe>()!=null || p_collision.GetComponent<Checkpoint>() != null) //on prend les obstacles et on les ram�ne au d�but
        {
            p_collision.transform.position = new Vector3(7f, p_collision.transform.position.y, 0f);
        }
    }

}

