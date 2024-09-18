using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputController : MonoBehaviour
{
    public Vector2 movement;
    public bool isMoving;
    public Vector2 looking;
    public bool isLooking;
    public bool grow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnGrow(InputValue value)
    {
        if (value.isPressed)
        {
            grow = true;
        }
        else
        {
            grow = false;
        }
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void OnLook(InputValue value)
    {
        looking = value.Get<Vector2>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
