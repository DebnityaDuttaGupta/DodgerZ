using UnityEngine;
using System.Collections;

public class Player_Coliision : MonoBehaviour
{
    public Player_Movement movement;
    public AudioSource tickSound;
    //public AudioScource tickScource;


    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //GetComponent<Player_Movement>().enabled = false;
            tickSound.Play();
            FindObjectOfType<GameManager>().EndGame();
            
            
        }
    }
}
