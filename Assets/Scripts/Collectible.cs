using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{


    //player walks into collectable
    //add collectable to player
    //delete collectable from the screen

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Player player = collision.GetComponent<Player>();

        if (player)
        {
            player.numTomato++;
            Destroy(this.gameObject);
        }

    }

}
