using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour
{
    public GameObject baloonTextPlayer;
    public Animator baloonTextAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character1")
        {
            baloonTextPlayer.gameObject.SetActive(true);
            baloonTextAnim.GetComponent<Animator>().SetBool("Character1", true);
            print("BaloonTextPlayer1");
        }

        if (collision.gameObject.tag == "Character2")
        {
            baloonTextPlayer.gameObject.SetActive(true);
            baloonTextAnim.GetComponent<Animator>().SetBool("Character2", true);
            print("BaloonTextPlayer2");
        }
        if (collision.gameObject.tag == "Character3")
        {
            baloonTextPlayer.gameObject.SetActive(true);
            baloonTextAnim.GetComponent<Animator>().SetBool("Character3", true);
            print("BaloonTextPlayer3");
        }

        if (collision.gameObject.tag == "Character4")
        {
            baloonTextPlayer.gameObject.SetActive(true);
            baloonTextAnim.GetComponent<Animator>().SetBool("Character4", true);
            print("BaloonTextPlayer4");
        }
        
        if (collision.gameObject.tag == "Character5")
        {
            baloonTextPlayer.gameObject.SetActive(true);
            baloonTextAnim.GetComponent<Animator>().SetBool("Character5", true);
            print("BaloonTextPlayer5");
        }
    }

}