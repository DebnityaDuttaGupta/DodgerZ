using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource tickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisonEnter (Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            tickSound.Play();
        }
    }
}
