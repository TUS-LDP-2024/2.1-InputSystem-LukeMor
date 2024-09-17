using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputController : MonoBehaviour
{
    public Rigidbody rb;
    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMove(InputValue value)
    {
        rb.velocity = value.Get<Vector2>() * MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
