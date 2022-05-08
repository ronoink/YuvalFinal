using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideGeneric : MonoBehaviour
{

    public GameObject baloonCharacter;
  //  public GameObject baloonPlayer;
 //   public Animator baloonAnimPlayer;
   // public GameObject stopHallMove;
   // public Animator playerStopanim;
   // public Animator characterstopanimation;
    public Animator baloonAnim;
   // public GameObject PlayerStopMove;
   // public GameObject characterStopMove;
   public GameObject moodbar;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     if (collision.gameObject.tag == "Player")
     {
      baloonCharacter.gameObject.SetActive(true);
      baloonAnim.GetComponent<Animator>().SetBool("BaloonStart" , true);
      print("collisionok");
      // stopHallMove.GetComponent<MoveBG>().moveSpeed = 0;
      //  playerstopanimation.GetComponent<Animator>().SetInteger("PlayerStop" , 0);
      // PlayerStopMove.GetComponent<Move>().moveSpeed = 0;
      //   characterstopanimation.GetComponent<Animator>().SetBool("CharacterStop" , true);
      //  characterStopMove.GetComponent<MoveBG>().moveSpeed = 0;
      moodbar.GetComponent<MoodBar>().Nextmood();
      //   baloonPlayer.gameObject.SetActive(true);
      //  baloonAnimPlayer.GetComponent<Animator>().SetBool("BaloonStart" , true);
      //   playerStopanim.GetComponent<Animator>().SetBool("PlayerStopAnim" , true);
     }

        
    }
    

    
}
