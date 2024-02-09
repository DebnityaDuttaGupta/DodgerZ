using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public float moveSpeed = 500;
    public GameObject character;

    private Rigidbody characterBody;
    private float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while(i < Input.touchCount)
        {
            if (Input.GetTouch (i).position.x > ScreenWidth / 2)
            {
                RunCharacter(5.0f);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                RunCharacter(-5.0f);
            }
            ++i;
        }
    }
   

    private void RunCharacter(float horizontalInput)
    {
        characterBody.AddForce(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0));

    }
}
