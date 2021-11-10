using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour //le bird décède s'il se prend un obstacle
{

    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>()!=null)
        {
           
            FindObjectOfType<UIManager>().triggerGameOver();
        }
        
    }

}
