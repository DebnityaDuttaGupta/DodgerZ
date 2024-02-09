using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public float moveSpeed = 500;
    public GameObject character;

    private Rigidbody characterBody;

    bool ishold;

    public void play_sound(int s)
    {
        AudioManager.instance.s_playsound(s);
    }

    public void pointerDown()
    {
        ishold = true;
    }

    public void pointerUp()
    {
        ishold = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        characterBody = character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && ishold)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            RunCharacter(5.0f);
        }


    }
    private void RunCharacter(float horizontalInput)
    {
        characterBody.AddForce(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0));

    }
}
