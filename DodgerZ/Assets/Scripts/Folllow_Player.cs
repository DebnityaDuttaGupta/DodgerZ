using System.Collections.Specialized;
using UnityEngine;

public class Folllow_Player : MonoBehaviour
{
    //transform causes the camera to stay in one particualr axis where the player is moving
    public Transform player;
    //vector3 is making the camera a bit off so we can view the payer in thirdperson and not in forst
    public Vector3 offset;
        
    // Update is called once per frame
    void Update()
    {
        //addition of vectors
        transform.position = player.position + offset;
    }
}
