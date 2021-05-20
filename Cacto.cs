using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cacto : MonoBehaviour
{
    public Slider vidaPlayer;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            vidaPlayer.value--;

        }
    }

    private void Update()
    {
        if(vidaPlayer.value == 0)
        {
            player.SetActive(false);
        }
    }
}
